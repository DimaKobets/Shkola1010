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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ComboBox.Items.Add("byte");
            ComboBox.Items.Add("sbyte");
            ComboBox.Items.Add("short");
            ComboBox.Items.Add("ushort");
            ComboBox.Items.Add("int");
            ComboBox.Items.Add("uint");
            ComboBox.Items.Add("long");
            ComboBox.Items.Add("ulong");

        }

        
      
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string comboBoxValue = ComboBox.SelectedItem.ToString();

            switch (comboBoxValue)
            {
                case "byte":
                    ShowMassage("byte", "8", "0", "255");
                    break;
                case "sbyte":
                    ShowMassage("sbyte", "8", "-128", "127");
                    break;
                case "short":
                    ShowMassage("short", "16", "-32768", "32767");
                    break;
                case "ushort":
                    ShowMassage("ushort", "16", "0", "65535");
                    break;
                case "int":
                    ShowMassage("int", "32", "-2147483648", "2147483647");
                    break;
                case "uint":
                    ShowMassage("uint", "32", "0", "4294967295");
                    break;
                case "long":
                    ShowMassage("long", "64", "-9223372036854775808", "9223372036854775807");
                    break;
                case "ulong":
                    ShowMassage("ulong", "64", "0", "18446744073709551615");
                    break;             
                    
            }

        }

        private void ShowMassage(string tipe, string bitDepth, string minValue, string maxValue)
        {
            massage.Text = "Числовой тип " + tipe + " имеет разрядность " + bitDepth +
               " бит и его значения лежат в диапазоне от " + minValue + " до " + maxValue;
        }

    }
}
