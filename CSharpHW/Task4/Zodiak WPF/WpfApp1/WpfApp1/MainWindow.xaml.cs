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
using System.Reflection;

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
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBlock.Text = "";
            SetPicture(GetSign(dateBox.Text));
            ShowMassage(GetSign(dateBox.Text));
            
        }

        private string GetSign(string dateOfBirth)
        {
            textBlock.Text = "";
            int[] date = StringToInt(SplitString(dateOfBirth));
            
            if (!textBlock.Text.Contains("Values entered incorrectly.\n") && DateValidation(date))
            {
                if ((date[1] == 3 && date[0] >= 21) || (date[1] == 4 && date[0] <= 19))
                {
                   return ("Ram");
                }
                else if ((date[1] == 4 && date[0] >= 20) || (date[1] == 5 && date[0] <= 20))
                {
                    return ("Bull");
                }
                else if ((date[1] == 5 && date[0] >= 21) || (date[1] == 6 && date[0] <= 20))
                {
                    return ("Twins");
                }
                else if ((date[1] == 6 && date[0] >= 21) || (date[1] == 7 && date[0] <= 22))
                {
                    return ("Crab");
                }
                else if ((date[1] == 7 && date[0] >= 23) || (date[1] == 8 && date[0] <= 22))
                {
                    return ("Lion");
                }
                else if ((date[1] == 8 && date[0] >= 23) || (date[1] == 9 && date[0] <= 22))
                {
                    return ("Maiden");
                }
                else if ((date[1] == 9 && date[0] >= 23) || (date[1] == 10 && date[0] <= 22))
                {
                    return("Scales");
                }
                else if ((date[1] == 10 && date[0] >= 23) || (date[1] == 11 && date[0] <= 21))
                {
                    return ("Scorpion");
                }
                else if ((date[1] == 11 && date[0] >= 22) || (date[1] == 12 && date[0] <= 21))
                {
                    return ("Archer");
                }
                else if ((date[1] == 12 && date[0] >= 22) || (date[1] == 1 && date[0] <= 19))
                {
                    return ("Mountain Sea-goat");
                }
                else if ((date[1] == 1 && date[0] >= 20) || (date[1] == 2 && date[0] <= 18))
                {
                    return ("Water-bearer");
                }
                else 
                {
                    return ("Fish");
                }
            }
            else
            {
                return ("Error");
            }
        }

        private void ShowMassage(string sign)
        {
            if (sign != "Error")
            {
                textBlock.Text = "Your sign of the zodiac is " + sign;
            }
            
        }
        private void SetPicture(string sign)
        {          
            signImage.Source = BitmapFrame.Create(new Uri(@"F:\C# projects\6 Zodiak WPF\" + sign + ".jpg"));
        }
                
        private string[] SplitString(string str)
        {
            string[] split = str.Split(new char[] { '/' });
            return split;
        }

        private int[] StringToInt(string[] splitedString)
        {
            int[] operand = new int[splitedString.Length];
            try
            {
                for (int i = 0; i < splitedString.Length; i++)
                    operand[i] = Convert.ToInt32(splitedString[i]);
            }
            catch (FormatException)
            {
                textBlock.Text = "Values entered incorrectly.\n";
            }
            return operand;
        }

        private bool DateValidation(int[] date)
        {
            bool errorFlag = true;
            if (!(0 < date[0] && date[0] < 32))
            {
                textBlock.Text += "The day of your birth date entered wrong.\n";
                errorFlag = false;
            }
            if (!(0 < date[1] && date[1] < 13))
            {
                textBlock.Text += "The month of your birth date entered wrong.\n";
                errorFlag = false;
            }
            if (!(date[2] <= DateTime.Now.Year))
            {
                textBlock.Text += "The year of your birth date entered wrong.\n";
                errorFlag = false;
            }
            return errorFlag;
        }
    }
}

