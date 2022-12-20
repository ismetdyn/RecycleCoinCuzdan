using Google.Protobuf.Reflection;
using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using RecycleCoin.Grpc;
using System;
using System.Reflection;
using System.Windows.Forms;
using static RecycleCoin.Grpc.BlokServis;
using static RecycleCoin.Grpc.HesapServis;
using static RecycleCoin.Grpc.IslemServis;

namespace RecycleCoinCuzdan
{
    public partial class AnaPencere : Form
    {
        
        GrpcChannel _kanal;

        List<Islem> bekleyenIslemler, gecmisTumIslemler;

        Cuzdan _cuzdan { get; set; }
        Hesap _hesap { get; set; }

        string _adres;

        public AnaPencere()
        {
            InitializeComponent();
            Ilklendir();
        }

        private void Ilklendir()
        {
            _cuzdan = Program.cuzdan;
            _kanal = Program.kanal;
            _adres = _cuzdan.AdresGetir();
            lblAdres.Text = _adres;
            bekleyenIslemler = new List<Islem>();
            gecmisTumIslemler = new List<Islem>();
            sayac.Interval = 10000; // 10 sn
            sayac.Start();
        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbAliciAdres.Text)
                || nudMiktar.Value == 0)
            {
                MessageBox.Show(
                    "Bir adres ve miktar girmelisiniz", 
                    "Girdi Hatasi",MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
                return;
            }
            if(_kanal.State == Grpc.Core.ConnectivityState.Ready)
            {
                try
                {
                    GonderimYap();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
        
        private void sayac_Tick(object sender, EventArgs e)
        {
            try
            {
                Guncelle();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void Guncelle()
        {
            try
            {
                SunucuDurumGuncelle();
                HesapGuncelle();
                IslemleriGetir();
                //BakiyeGuncelle();
                ArayuzuGuncelle();
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void GonderimYap()
        {
            if(_kanal.State == Grpc.Core.ConnectivityState.Ready && _hesap != null)
            {
                var tutar = (double)nudMiktar.Value;
                var alici = tbAliciAdres.Text.Trim();
                Islem yeniIslem;
				IslemIstek aktarimIstegi;
                if (tutar > _hesap.Bakiye)
                {
                    MessageBox.Show("Bakiye Yetersiz");
                    return;
                }
                else
                {
                    try
                    {
                        yeniIslem = new Islem
                        {
                            ZamanDamgasi = Diger.Hizmetler.ZamanGetir(),
                            Gonderen = _cuzdan.AdresGetir(),
                            Alici = alici,
                            Tutar = tutar,
                            Ucret = 0,
                            IslemTipi = "Aktar",
                            GenelAnahtar = _cuzdan.GenelAnahtarGetir().ToString()
                        };
                        var islemKarmasi = Diger.Hizmetler.IslemKarmasiOlustur(yeniIslem);
                        var imza = _cuzdan.Imzala(islemKarmasi);
                        yeniIslem.Karma = islemKarmasi;
                        yeniIslem.Imza = imza;
                        aktarimIstegi = new IslemIstek { Islem = yeniIslem };

                        var aktarimYaniti = Program.islemServis.Aktar(aktarimIstegi);
                        if (aktarimYaniti.Durum == true) MessageBox.Show("===BASARILI===");
                        else MessageBox.Show("Hata: ", aktarimYaniti.Mesaj);
                    }
                    catch
                    {
                        throw;
                    }       
                }
            }
        }


        private void IslemleriGetir()
        {
            if(_kanal.State == Grpc.Core.ConnectivityState.Ready)
            {
                try
                {
                    var gecmisIslemlerYaniti = Program.islemServis.AdresIleListeGetir(new IslemIstek { Adres = _adres });
                    if (gecmisIslemlerYaniti != null
                        && gecmisIslemlerYaniti.Durum == true 
                        && gecmisIslemlerYaniti.Islemler != null 
                        && gecmisIslemlerYaniti.Islemler.Count > 0)
                    {
                        gecmisTumIslemler.Clear();
                        gecmisTumIslemler.AddRange(gecmisIslemlerYaniti.Islemler);
                    }

                    var bekleyenIslemlerYaniti = Program.islemServis.HavuzdanAdresIleListeGetir(new IslemIstek { Adres = _adres });
                    if (bekleyenIslemlerYaniti != null
                        && bekleyenIslemlerYaniti.Durum == true 
                        && bekleyenIslemlerYaniti.Islemler != null 
                        && bekleyenIslemlerYaniti.Islemler.Count > 0)
                    {
                        bekleyenIslemler.Clear();
                        bekleyenIslemler.AddRange(bekleyenIslemlerYaniti.Islemler);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void SunucuDurumGuncelle()
        {
            if(_kanal.State != Grpc.Core.ConnectivityState.Ready)
            {
                try
                {
                    var DUGUM_ADRESI = DotNetEnv.Env.GetString("DUGUM_ADRESI");
                    //if (_kanal != null) _kanal.Dispose();
                    _kanal = GrpcChannel.ForAddress(DUGUM_ADRESI);
                    if (_kanal.State != Grpc.Core.ConnectivityState.Ready) _kanal.ConnectAsync();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void HesapGuncelle()
        {
            if (_kanal.State == Grpc.Core.ConnectivityState.Ready)
            {
                try
                {
                    var yanit = Program.hesapServis.AdresIleGetir(new HesapIstek { Adres = _adres });
                    if (!yanit.Durum)
                    {
                        var yanit2 = Program.hesapServis.Ekle(new HesapIstek
                        {
                            Hesap = new Hesap
                            {
								Adres = _adres,
							    GenelAnahtar = _cuzdan.GenelAnahtarGetir().ToString()
							}
                        });
                        if (!yanit2.Durum) throw new Exception("Hesap eklenemiyor");
                    }
                    else _hesap = yanit.Hesap;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void btnAdresKopyala_Click(object sender, EventArgs e)
        {
            
        }

        private void ArayuzuGuncelle()
        {
            lblSunucuDurum.Text = _kanal.State.ToString();
            if (_kanal.State == Grpc.Core.ConnectivityState.Connecting) lblSunucuDurum.ForeColor = Color.Blue;
            else if (_kanal.State == Grpc.Core.ConnectivityState.Ready) lblSunucuDurum.ForeColor = Color.Green;
            else if (_kanal.State == Grpc.Core.ConnectivityState.Idle) lblSunucuDurum.ForeColor = Color.Yellow;
            else if (_kanal.State == Grpc.Core.ConnectivityState.Shutdown) lblSunucuDurum.ForeColor = Color.Red;
            
            //-------------

            lblBakiye.Text = "Guncel bilgi alinmaya calisiliyor";
            lblOnaylanmamisBakiye.Text = "Guncel bilgi alinmaya calisiliyor";

            double onaylanmamisBakiye = 0;
            foreach (var islem in bekleyenIslemler)
                onaylanmamisBakiye += islem.Tutar;

            if (_hesap != null) lblBakiye.Text = _hesap.Bakiye.ToString() + " RC";
            if (_hesap != null) lblOnaylanmamisBakiye.Text = onaylanmamisBakiye.ToString() + " RC";

            // -------------
            TreeNode n;
            treeViewGecmisIslemler.Nodes.Clear();
            treeViewBekleyenIslemler.Nodes.Clear();
            int sayac = gecmisTumIslemler.Count;
            foreach (Islem islem in gecmisTumIslemler)
            {
                n = new TreeNode()
                {
                    Name = $"Islem {sayac}",
                    Text = $"Islem {sayac}",
                };
                treeViewGecmisIslemler.Nodes.Add(n);

                PropertyInfo[] properties = typeof(Islem).GetProperties();
                foreach (var pi in properties)
                {
                    
                    TreeNode treeNode = new()
                    {
                        Name = pi.Name.ToString(),
                        Text = "\b"+pi.Name.ToString() + ": " + pi.GetValue(islem).ToString()
                    };

                    n.Nodes.Add(treeNode);
                }
                sayac--;
            }

           
            //---------
            lblAdres.Text = _adres;

            if (_hesap == null) btnGonder.Enabled = false;
            else btnGonder.Enabled = true;

            if (string.IsNullOrEmpty(_adres)) btnAdresKopyala.Enabled = false;
            else btnAdresKopyala.Enabled = true;
        }

        public void BakiyeGuncelle()
        {
            if(gecmisTumIslemler != null && gecmisTumIslemler.Count > 0)
            foreach (var islem in gecmisTumIslemler)
            {
                    if (islem.Gonderen == _hesap.Adres) _hesap.Bakiye -= islem.Tutar;
                    else if (islem.Alici == _hesap.Adres) _hesap.Bakiye += islem.Tutar;
            }
        }
    }
}