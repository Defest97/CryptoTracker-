using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace CryptoTracker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Currency[] Top5CryptoCurrencies = new Currency[5] { new Currency("bitcoin")
                    , new Currency("ethereum"), new Currency("dogecoin")
                    , new Currency("cardano"), new Currency("usd-coin") };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Regex regex = new Regex("(\"id\":\"\\w{0,}\")");
            Currency[] mas = new Currency[10];
            string name = Currency.Myjson("");
            MatchCollection match = regex.Matches(name);

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = new Currency(Currency.GetBetween(match[i].Value, "\"id\":\"", "\""), i + 1);
                _ = gridTable.Items.Add(mas[i]);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Currency.GridAction(Top5CryptoCurrencies, this);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Currency obj = new Currency(CurrencyToFind.Text);
            _ = gridSearch.Items.Add(obj);
        }

        private void Kraken_Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            _ = Process.Start(new ProcessStartInfo("https://www.kraken.com/") { UseShellExecute = true });
        }

        private void BinanceUS_Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            _ = Process.Start(new ProcessStartInfo("https://www.binance.us/en") { UseShellExecute = true });
        }

        private void Base_Loaded(object sender, RoutedEventArgs e)
        {
            if (Base.Items.Count == 0)
            {
                for (int i = 0; i < Top5CryptoCurrencies.Length; i++)
                {
                    _ = Base.Items.Add(Top5CryptoCurrencies[i].NameCur);
                }
            }
        }

        private void Quote_Loaded(object sender, RoutedEventArgs e)
        {
            if (Quote.Items.Count == 0)
            {
                for (int i = 0; i < Top5CryptoCurrencies.Length; i++)
                {
                    _ = Quote.Items.Add(Top5CryptoCurrencies[i].NameCur);
                }
            }
        }

        private void Base_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < Top5CryptoCurrencies.Length; i++)
            {
                if (Base.SelectedItem.ToString() == Top5CryptoCurrencies[i].NameCur)
                {
                    labelBase.Content = comboboxLanguage.SelectedIndex == 0
                        ? "Price for 1 unit = " + Top5CryptoCurrencies[i].PriceUSD.ToString()
                        : "Ціна за 1 одиницю = " + Top5CryptoCurrencies[i].PriceUSD.ToString();
                }
            }
        }

        private void Quote_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < Top5CryptoCurrencies.Length; i++)
            {
                if (Quote.SelectedItem.ToString() == Top5CryptoCurrencies[i].NameCur)
                {
                    labelQuote.Content = comboboxLanguage.SelectedIndex == 0
                        ? "Price for 1 unit = " + Top5CryptoCurrencies[i].PriceUSD.ToString()
                        : "Ціна за 1 одиницю = " + Top5CryptoCurrencies[i].PriceUSD.ToString();
                }
            }
        }

        private void Count_Click(object sender, RoutedEventArgs e)
        {
            labelBetween.Visibility = Visibility.Visible;
            decimal baseCur = 0;
            decimal quoteCur = 0;
            for (int i = 0; i < Top5CryptoCurrencies.Length; i++)
            {
                if (Base.SelectedItem.ToString() == Top5CryptoCurrencies[i].NameCur)
                {
                    baseCur = (decimal)Top5CryptoCurrencies[i].PriceUSD;
                }

                if (Quote.SelectedItem.ToString() == Top5CryptoCurrencies[i].NameCur)
                {
                    quoteCur = (decimal)Top5CryptoCurrencies[i].PriceUSD;
                }
            }

            string answer = (decimal.Parse(textboxBase.Text) * baseCur / quoteCur).ToString();
            textboxQuote.Text = answer.Length > 10 ? answer.Remove(10) : answer;
        }

        private void DarkTheme_Checked(object sender, RoutedEventArgs e)
        {
            Style stylegrid = new Style(typeof(System.Windows.Controls.Primitives.DataGridColumnHeader));
            stylegrid.Setters.Add(new Setter { Property = BackgroundProperty, Value = Brushes.SlateGray });

            Theme.DarkTheme(this, stylegrid);
        }

        private void LightTheme_Checked(object sender, RoutedEventArgs e)
        {
            Style stylegrid = new Style(typeof(System.Windows.Controls.Primitives.DataGridColumnHeader));
            stylegrid.Setters.Add(new Setter { Property = BackgroundProperty, Value = Brushes.WhiteSmoke });
            Theme.LightTheme(this, stylegrid);

        }

        private void Language_Loaded(object sender, RoutedEventArgs e)
        {
            _ = comboboxLanguage.Items.Add("English");
            _ = comboboxLanguage.Items.Add("Українська");
        }

        private void Language_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AppLanguage.Language_Selection(this);
        }
    }
}

