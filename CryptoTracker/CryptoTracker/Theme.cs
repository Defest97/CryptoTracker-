using System.Windows.Media;
using System.Windows;

namespace CryptoTracker
{
    public class Theme
    {
        public static void DarkTheme(MainWindow mainWindow, Style stylegrid)
        {
            mainWindow.Background = new SolidColorBrush(Colors.DarkSlateGray);
            mainWindow.TabControl.Background = new SolidColorBrush(Colors.DarkSlateGray);
            mainWindow.gridTable.ColumnHeaderStyle = stylegrid;
            mainWindow.gridInfo.ColumnHeaderStyle = stylegrid;
            mainWindow.gridSearch.ColumnHeaderStyle = stylegrid;
            {
                mainWindow.labeltop.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.gridTable.RowBackground = new SolidColorBrush(Colors.SaddleBrown);
                mainWindow.gridTable.AlternatingRowBackground = new SolidColorBrush(Colors.Teal);
                mainWindow.gridTable.Background = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.gridTable.BorderBrush = new SolidColorBrush(Colors.DimGray);
            }
            {
                mainWindow.headerLabel.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.bitcoinLabel.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.ethereumLabel.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.dogecoinLabel.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.cardanoLabel.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.usdcoinLabel.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.gridInfo.RowBackground = new SolidColorBrush(Colors.SaddleBrown);
                mainWindow.gridInfo.AlternatingRowBackground = new SolidColorBrush(Colors.Teal);
                mainWindow.gridInfo.Background = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.gridInfo.BorderBrush = new SolidColorBrush(Colors.DimGray);
                mainWindow.headerInfoprice.Foreground = new SolidColorBrush(Colors.DarkRed);
            }
            {
                mainWindow.gridSearch.RowBackground = new SolidColorBrush(Colors.SaddleBrown);
                mainWindow.gridSearch.AlternatingRowBackground = new SolidColorBrush(Colors.Teal);
                mainWindow.gridSearch.Background = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.gridSearch.BorderBrush = new SolidColorBrush(Colors.DimGray);
                mainWindow.labelcurfind.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.CurrencyToFind.Background = new SolidColorBrush(Colors.DarkKhaki);
            }
            {
                mainWindow.labelBase.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.labelQuote.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.labelBetween.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.labelAmount.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.labelSell.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.labelbuy.Foreground = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.textboxBase.Background = new SolidColorBrush(Colors.DarkKhaki);
                mainWindow.textboxQuote.Background = new SolidColorBrush(Colors.DarkKhaki);
            }
        }
        public static void LightTheme(MainWindow mainWindow, Style stylegrid)
        {
            mainWindow.Background = new SolidColorBrush(Colors.Aquamarine);
            mainWindow.TabControl.Background = new SolidColorBrush(Colors.Aquamarine);
            mainWindow.gridTable.ColumnHeaderStyle = stylegrid;
            mainWindow.gridInfo.ColumnHeaderStyle = stylegrid;
            mainWindow.gridSearch.ColumnHeaderStyle = stylegrid;
            {
                mainWindow.labeltop.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.gridTable.RowBackground = new SolidColorBrush(Colors.LightYellow);
                mainWindow.gridTable.AlternatingRowBackground = new SolidColorBrush(Colors.LightBlue);
                mainWindow.gridTable.Background = new SolidColorBrush(Colors.LightGray);
                mainWindow.gridTable.BorderBrush = new SolidColorBrush(Colors.Gray);
            }
            {
                mainWindow.headerLabel.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.bitcoinLabel.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.ethereumLabel.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.dogecoinLabel.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.cardanoLabel.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.usdcoinLabel.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.gridInfo.RowBackground = new SolidColorBrush(Colors.LightYellow);
                mainWindow.gridInfo.AlternatingRowBackground = new SolidColorBrush(Colors.LightBlue);
                mainWindow.gridInfo.Background = new SolidColorBrush(Colors.LightGray);
                mainWindow.gridInfo.BorderBrush = new SolidColorBrush(Colors.Gray);
                mainWindow.headerInfoprice.Foreground = new SolidColorBrush(Colors.Red);
            }
            {
                mainWindow.gridSearch.RowBackground = new SolidColorBrush(Colors.LightYellow);
                mainWindow.gridSearch.AlternatingRowBackground = new SolidColorBrush(Colors.LightBlue);
                mainWindow.gridSearch.Background = new SolidColorBrush(Colors.LightGray);
                mainWindow.gridSearch.BorderBrush = new SolidColorBrush(Colors.Gray);
                mainWindow.labelcurfind.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.CurrencyToFind.Background = new SolidColorBrush(Colors.White);
            }
            {
                mainWindow.labelBase.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.labelQuote.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.labelBetween.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.labelAmount.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.labelSell.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.labelbuy.Foreground = new SolidColorBrush(Colors.CornflowerBlue);
                mainWindow.textboxBase.Background = new SolidColorBrush(Colors.White);
                mainWindow.textboxQuote.Background = new SolidColorBrush(Colors.White);
            }
        }
    }
}
