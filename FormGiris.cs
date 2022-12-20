using Grpc.Net.Client;
using System.Text;

namespace RecycleCoinCuzdan
{
    public partial class FormGiris : Form
    {
        public bool BasariliHesapKurtarma { get; private set; }
        public bool YeniKullanici { get; private set; }
        public bool EskiKullanici { get; private set; }

        bool _gorunurluk;
        string _animsatici;
        protected internal Cuzdan _cuzdan;
        GrpcChannel _kanal;
        public FormGiris()
        {
            InitializeComponent();
            Ilklendir();
        }
        void Ilklendir()
        {
            this.Width = 535;
            this.Height = 310;
            _animsatici = DotNetEnv.Env.GetString("ANIMSATICI").ToString().Trim();
            sayac.Interval = 15;
            _gorunurluk = false;
            panelText.Height = 0;
            panelText.Visible = false;
            panelText.Enabled = false;
            btnTamam.Enabled = false;
            if (string.IsNullOrEmpty(_animsatici)) btnAc.Enabled = false;
            timerSunucuDurum.Interval = 5000;
            timerSunucuDurum.Start();
        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            try
            {
                _cuzdan = new Cuzdan(_animsatici);
                Program.cuzdan = new Cuzdan(_animsatici);
                EskiKullanici = true;
                this.Close();
            }
            catch (Exception hata)
            {
                EskiKullanici=false;
                BasariliHesapKurtarma = false;
                YeniKullanici = false;
                MessageBox.Show(hata.Message);
            }
        }
        private void btnYeni_Click(object sender, EventArgs e)
        {
            try
            {
                YeniKullanici = true;
                BasariliHesapKurtarma=false;
                EskiKullanici =false;
                Program.cuzdan = new Cuzdan();
                _animsatici = Program.cuzdan.Animsatici.ToString();
                EnvDosyasiniGuncelle();
                MessageBox.Show(
                    Program.cuzdan.Animsatici.ToString(), 
                    "Dikkat! Lutfen asagidaki kelimeleri saklayiniz.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception hata)
            {
                YeniKullanici = false;
                BasariliHesapKurtarma = false;
                EskiKullanici = false;
                MessageBox.Show(hata.Message);
            }
        }

        private void btnOnar_Click(object sender, EventArgs e)
        {
            if(_gorunurluk) _gorunurluk = false;
            else _gorunurluk = true;
            sayac.Start();
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            try
            {
                _animsatici = tbAnimsatici.Text.Trim();
                BasariliHesapKurtarma = true;
                Program.cuzdan = new Cuzdan(_animsatici);
                EnvDosyasiniGuncelle();
                this.Close();
            }
            catch (Exception hata)
            {
                BasariliHesapKurtarma = false;
                MessageBox.Show(hata.Message);
            }
        }

        private void sayac_Tick(object sender, EventArgs e)
        {
            if(_gorunurluk)
            {
                this.Height += 8;
                panelText.Height += 8;
                panelText.Visible = true;
                panelText.Enabled = true;
                if (panelText.Height == panelText.MaximumSize.Height) sayac.Stop();
            }
            else
            {
                this.Height -= 8;
                panelText.Height -= 8;
                //panelText.Visible = false;
                panelText.Enabled = false;
                if (panelText.Height == panelText.MinimumSize.Height) sayac.Stop();
            }
        }

        private void GirdiKontrol()
        {
            string animsatici = tbAnimsatici.Text.Trim();
            if (string.IsNullOrEmpty(animsatici) || string.IsNullOrWhiteSpace(animsatici))
                btnTamam.Enabled = false;
            else if (animsatici.Split(" ").Count() != 12) btnTamam.Enabled = false;
            else btnTamam.Enabled = true;
        }

        private void tbAnimsatici_KeyUp(object sender, KeyEventArgs e)
        {
            GirdiKontrol();
        }

        private void tbAnimsatici_KeyDown(object sender, KeyEventArgs e)
        {
            GirdiKontrol();
        }

        private void tbAnimsatici_TextChanged(object sender, EventArgs e)
        {
            GirdiKontrol();
        }

        private void EnvDosyasiniGuncelle()
        {
            
            DirectoryInfo klasor = new(Directory.GetCurrentDirectory());
            while (klasor != null && !klasor.GetFiles(".sln").Any())
            {
                    if (klasor.GetFiles(".env").Any()) break;
                    else klasor = klasor.Parent;
            }

            string animsaticiToEnv = $"\nANIMSATICI=\"{_animsatici}\"";

            if (klasor.GetFiles(".env").Any())
            {
                var dosya = klasor.GetFiles(".env")[0];
                var lines = File.ReadAllLines(dosya.FullName);
                for (int i = 0; i < lines.Length; i++)
                {
                   if (lines[i].Contains("ANIMSATICI"))
                   {
                        lines[i] = animsaticiToEnv;
                   }
                }
                File.WriteAllLines(dosya.FullName, lines);
            }
            else
            {
                File.Create(klasor.FullName + "\\\\.env");
                var str2 = File.ReadAllText(".env");
                str2 += animsaticiToEnv;
                File.WriteAllText(".env", str2);
            }
        }

        private void btnIptal_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void SunucuDurumGuncelle()
        {
            try
            {
                var DUGUM_ADRESI = DotNetEnv.Env.GetString("DUGUM_ADRESI");
                if(_kanal != null) _kanal.Dispose();
                _kanal = GrpcChannel.ForAddress(DUGUM_ADRESI);
                if (_kanal.State != Grpc.Core.ConnectivityState.Ready) _kanal.ConnectAsync();                
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void timerSunucuDurum_Tick(object sender, EventArgs e)
        {
            SunucuDurumGuncelle();
            lblSunucuDurum.Text = _kanal.State.ToString();
            if (_kanal.State == Grpc.Core.ConnectivityState.Ready) lblSunucuDurum.ForeColor = Color.Green;
            if (_kanal.State == Grpc.Core.ConnectivityState.Idle) lblSunucuDurum.ForeColor = Color.Yellow;
            if (_kanal.State == Grpc.Core.ConnectivityState.Connecting) lblSunucuDurum.ForeColor = Color.Blue;
            if (_kanal.State == Grpc.Core.ConnectivityState.Shutdown) lblSunucuDurum.ForeColor = Color.Blue;
        }

    }
}
