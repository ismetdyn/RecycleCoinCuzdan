using Grpc.Net.Client;
using static RecycleCoin.Grpc.BlokServis;
using static RecycleCoin.Grpc.HesapServis;
using static RecycleCoin.Grpc.IslemServis;

namespace RecycleCoinCuzdan
{
    internal static class Program
    {
        public static GrpcChannel kanal;
        public static Cuzdan cuzdan;
		public static HesapServisClient hesapServis;
		public static BlokServisClient  blokServis;
		public static IslemServisClient islemServis;
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
        static void Main()
        {
            DotNetEnv.Env.Load();
            DotNetEnv.Env.TraversePath().Load();

            var DUGUM_ADRESI = DotNetEnv.Env.GetString("DUGUM_ADRESI");
            AppContext.SetSwitch(
                "System.Net.SocketsHttpHandler.Http3Support", true);
            kanal = GrpcChannel.ForAddress(DUGUM_ADRESI);
            ApplicationConfiguration.Initialize();
            hesapServis = new HesapServisClient(kanal);
            blokServis = new BlokServisClient(kanal);
            islemServis = new IslemServisClient(kanal);

            FormGiris formGiris = new();
            Application.Run(formGiris);
            if (formGiris.EskiKullanici) Application.Run(new AnaPencere());
            else if (formGiris.YeniKullanici) Application.Run(new AnaPencere());
            else if (formGiris.BasariliHesapKurtarma) Application.Run(new AnaPencere());
        }

        public static void BaglantiGuncelle()
        {
            string DUGUM_ADRESI;
            if (kanal != null) kanal.Dispose();
            if(kanal.State != Grpc.Core.ConnectivityState.Ready)
            {
                DUGUM_ADRESI = DotNetEnv.Env.GetString("DUGUM_ADRESI");
                kanal = GrpcChannel.ForAddress(DUGUM_ADRESI);
            }   
        }
    }
}