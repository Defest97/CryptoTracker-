
namespace CryptoTracker
{
    public class AppLanguage
    {
        public static void Language_Selection(MainWindow mainWindow)
        {
            switch (mainWindow.comboboxLanguage.SelectedItem.ToString())
            {
                case "English":
                    {
                        mainWindow.labeltop.Content = "Top 10 Cryptocurrencies by CoinCap Api 2.0";
                        mainWindow.headerName.Header = "Name currency";
                        mainWindow.headerMainprice.Header = "Price In USD";
                        mainWindow.headerLabel.Content = "Top 5 cryptocurrencies by popularity";
                        mainWindow.refresh.Content = "Refresh";
                        mainWindow.headerInfoprice.Header = "Price In USD";
                        mainWindow.headerVolume.Header = "Volume";
                        mainWindow.headerpricechange.Header = "Price Change";
                        mainWindow.headerMarkets.Header = "Markets:";
                        mainWindow.labelcurfind.Content = "Currency to find";
                        mainWindow.buttonFind.Content = "Find";
                        mainWindow.headerNamefind.Header = "Name currency";
                        mainWindow.headerVolumefind.Header = "Refresh";
                        mainWindow.headerPricechangefind.Header = "Price Change";
                        mainWindow.headerPriceUSDfind.Header = "Price In USD";
                        mainWindow.labelBase.Content = "Price for 1 unit = 0";
                        mainWindow.labelQuote.Content = "Price for 1 unit = 0";
                        mainWindow.labelAmount.Content = "Amount of units";
                        mainWindow.labelSell.Content = "Sell";
                        mainWindow.labelbuy.Content = "Buy";
                        mainWindow.Count.Content = "Count";
                        mainWindow.lighttheme.Content = "Light Theme";
                        mainWindow.darktheme.Content = "Dark Theme";
                        mainWindow.tabitemMainpage.Header = "Main page";
                        mainWindow.tabitemDetailedInformation.Header = "Detailed Information";
                        mainWindow.tabitemСurrencySearch.Header = "Сurrency Search";
                        mainWindow.tabitemExchange.Header = "Exchange";
                    }
                    break;
                case "Українська":
                    {
                        mainWindow.labeltop.Content = "Топ 10 Криптовалют за CoinCap Api 2.0";
                        mainWindow.headerName.Header = "Назва валюти";
                        mainWindow.headerMainprice.Header = "Ціна в Долларах США";
                        mainWindow.headerLabel.Content = "Топ 5 Криптовалют за популярністю";
                        mainWindow.refresh.Content = "Оновити";
                        mainWindow.headerInfoprice.Header = "Ціна в Долларах США";
                        mainWindow.headerVolume.Header = "Кількість";
                        mainWindow.headerpricechange.Header = "Зміна ціни";
                        mainWindow.headerMarkets.Header = "Ринки:";
                        mainWindow.labelcurfind.Content = "Валюта для пошуку:";
                        mainWindow.buttonFind.Content = "Знайти";
                        mainWindow.headerNamefind.Header = "Назва валюти";
                        mainWindow.headerVolumefind.Header = "Кількість";
                        mainWindow.headerPricechangefind.Header = "Зміна ціни";
                        mainWindow.headerPriceUSDfind.Header = "Ціна в Долларах США";
                        mainWindow.labelBase.Content = "Ціна за 1 одиницю = 0";
                        mainWindow.labelQuote.Content = "Ціна за 1 одиницю = 0";
                        mainWindow.labelAmount.Content = "Кількість одиниць";
                        mainWindow.labelSell.Content = "Продаж";
                        mainWindow.labelbuy.Content = "Купівля";
                        mainWindow.Count.Content = "Порахувати";
                        mainWindow.lighttheme.Content = "Світла Тема";
                        mainWindow.darktheme.Content = "Темна Тема";
                        mainWindow.tabitemMainpage.Header = "Головна";
                        mainWindow.tabitemDetailedInformation.Header = "Детальна інформація";
                        mainWindow.tabitemСurrencySearch.Header = "Пошук Валюти";
                        mainWindow.tabitemExchange.Header = "Обмін";
                    }
                    break;

                default:
                    break;
            }
        }
    }
}
