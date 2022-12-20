using RecycleCoin.Grpc;
using System.Security.Cryptography;
using System.Text;

namespace RecycleCoinCuzdan.Diger
{
    public static class Hizmetler
    {
        public static string KarmaUret(string data)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(data);
            byte[] hash = SHA256.Create().ComputeHash(bytes);
            return BytesToHex(hash);
        }

        public static DateTime ToDateTime(long unixTime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTime).ToLocalTime();
            return dtDateTime;
        }

        public static long ZamanGetir()
        {
            long epochTicks = new DateTime(1970, 1, 1).Ticks;
            long nowTicks = DateTime.Now.Ticks;
            long tmStamp = (nowTicks - epochTicks) / TimeSpan.TicksPerSecond;
            return tmStamp;
        }

        public static string StringToHex(string veri)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(veri);
            return BytesToHex(bytes);
        }

        public static string BytesToHex(byte[] bytes)
        {
            return Convert.ToHexString(bytes).ToLower();
        }

        public static byte[] HexToBytes(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                .ToArray();
        }
   
        public static string IslemKarmasiOlustur(Islem islem)
        {
            var islemKarma = KarmaUret(KarmaUret(
                islem.ZamanDamgasi +
                islem.Gonderen +
                islem.Tutar +
                islem.Ucret +
                islem.Alici));
            return islemKarma;
        }
    }
}
