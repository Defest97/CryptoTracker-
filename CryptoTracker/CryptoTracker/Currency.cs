using System.Text.RegularExpressions;
using System.Net;
using System.IO;

namespace CryptoTracker
{
    public class Currency
    {
        public string NameCur { get; set; }
        public int ID { get; set; }
        public double PriceUSD { get; set; }
        public double Volume { get; set; }
        public double PriceChange { get; set; }
        public double[] PriceMarket { get; set; }

        public Currency(string namecur, int id)
        {
            NameCur = namecur;
            ID = id;
            PriceUSD = CoinCupApiinfo(Myjson(namecur), "priceUsd");
        }

        public Currency(string namecur)
        {
            NameCur = namecur;
            PriceUSD = CoinCupApiinfo(Myjson(namecur), "priceUsd");
            Volume = CoinCupApiinfo(Myjson(namecur), "supply");
            PriceChange = CoinCupApiinfo(Myjson(namecur), "changePercent24Hr");
            PriceMarket = new double[2];
            PriceMarket[0] = CoinCupApimarkets(Myjson(namecur + "/markets"), namecur, "Binance.US");
            PriceMarket[1] = CoinCupApimarkets(Myjson(namecur + "/markets"), namecur, "Kraken");
        }

        public static string Myjson(string namecur)
        {
            HttpWebRequest webRequest = WebRequest.Create("https://api.coincap.io/v2/assets/" + namecur) as HttpWebRequest;
            Stream s = webRequest.GetResponse().GetResponseStream();
            StreamReader sr = new StreamReader(s);
            string contributorsAsJson = sr.ReadToEnd();

            return contributorsAsJson;
        }

        public static double CoinCupApimarkets(string obj, string nameinfo, string namemarket)
        {
            string number = obj;
            Regex regex = new Regex(namemarket + "\",\"baseId\":\"" + nameinfo + "\",\"quoteId\":\"united-states-dollar\",\"baseSymbol\":\"[A-Z]{3,4}\",\"quoteSymbol\":\"USD\",\"volumeUsd24Hr\":\"\\d+\\.\\d+\",\"priceUsd\":\"\\d+\\.\\d+\",");
            Match match = regex.Match(number);

            if (match.Success)
            {
                number = match.Value;
                number = GetBetween(number, "priceUsd" + "\":\"", "\",").Remove(10).Replace(".", ",");
                return double.Parse(number);
            }

            return 0;
        }

        public static double CoinCupApiinfo(string number, string nameinfo)
        {
            number = GetBetween(number, nameinfo + "\":\"", "\",").Remove(10).Replace(".", ",");
            return double.Parse(number);
        }

        public static string GetBetween(string strSource, string strStart, string strEnd)
        {
            if (strSource.Contains(strStart) && strSource.Contains(strEnd))
            {
                int Start, End;
                Start = strSource.IndexOf(strStart, 0) + strStart.Length;
                End = strSource.IndexOf(strEnd, Start);
                return strSource.Substring(Start, End - Start);
            }
            return "";
        }
        public static void GridAction(Currency[] Top5CryptoCurrencies, MainWindow mainWindow)
        {
            mainWindow.gridInfo.Items.Clear();
            foreach (Currency item in Top5CryptoCurrencies)
            {
                _ = mainWindow.gridInfo.Items.Add(item);
            }
        }
    }
}
