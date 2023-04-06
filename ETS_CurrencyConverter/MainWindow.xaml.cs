using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace ETS_CurrencyConverter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /* var selectedItem1 = comboBox1.SelectedItem;
            var selectedItem2 = comboBox2.SelectedItem;

            if (selectedItem1.ToString() == selectedItem2.ToString())
            {
                textBox2.Text = textBox1.Text;
            } */
            /*var selected = comboBox1.GetItemText(comboBox1.SelectedItem);
            MessageBox.Show(selected); */

            double text1 = Convert.ToDouble(textBox1.Text);
            string currency1 = ((ComboBoxItem)comboBox1.SelectedItem).Content.ToString();
            string currency2 = ((ComboBoxItem)comboBox2.SelectedItem).Content.ToString();

            double amount = 1;
            if(currency1 == currency2) {
                amount = text1;
            } 
            else if(currency1 == "USD" && currency2 == "EUR") {
                amount = text1 * 0.92;
            } 
            else if(currency1 == "EUR" && currency2 == "USD") {
                amount = text1 * 1.09;
            }
            else if (currency1 == "USD" && currency2 == "IDR") {
                amount = text1 * 14963;
            }
            else if (currency1 == "IDR" && currency2 == "USD") {
                amount = text1 * 0.000067;
            }
            else if (currency1 == "USD" && currency2 == "JPY") {
                amount = text1 * 131;
            }
            else if (currency1 == "JPY" && currency2 == "USD") {
                amount = text1 * 0.0076;
            }
            else if (currency1 == "USD" && currency2 == "MYR") {
                amount = text1 * 4.4;
            }
            else if (currency1 == "MYR" && currency2 == "USD") {
                amount = text1 * 0.23;
            }
            else if (currency1 == "EUR" && currency2 == "IDR") {
                amount = text1 * 16323;
            }
            else if (currency1 == "IDR" && currency2 == "EUR") {
                amount = text1 * 0.000061;
            }
            else if (currency1 == "EUR" && currency2 == "JPY") {
                amount = text1 * 142.81;
            }
            else if (currency1 == "JPY" && currency2 == "EUR") {
                amount = text1 * 0.007;
            }
            else if (currency1 == "EUR" && currency2 == "MYR") {
                amount = text1 * 4.8;
            }
            else if (currency1 == "MYR" && currency2 == "EUR") {
                amount = text1 * 0.21;
            }
            else if (currency1 == "IDR" && currency2 == "JPY") {
                amount = text1 * 0.0087;
            }
            else if (currency1 == "JPY" && currency2 == "IDR") {
                amount = text1 * 114.28;
            }
            else if (currency1 == "IDR" && currency2 == "MYR") {
                amount = text1 * 0.00029;
            }
            else if (currency1 == "MYR" && currency2 == "IDR") {
                amount = text1 * 3401.84;
            }
            else if (currency1 == "JPY" && currency2 == "MYR") {
                amount = text1 * 0.034;
            }
            else if (currency1 == "MYR" && currency2 == "JPY") {
                amount = text1 * 29.74;
            }

            textBox2.Text = Math.Round(amount).ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            
        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {
            
        }

    }
}
