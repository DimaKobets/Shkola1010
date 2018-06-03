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
        int attempt = 2;
        static Random rnd = new Random();
        int randomeNumber = rnd.Next(1, 10);


        public MainWindow()
        {
            InitializeComponent();
        }

        public void checkButton_Click(object sender, RoutedEventArgs e)
        {
            randomeBlock.Text = "" + randomeNumber;

            if (NumberValidation())
            {
                if (randomeNumber != StringToInt(userNumber.Text))
                {
                    if (attempt > 1)
                    {                        
                        messageBlock.Text = "You did not guess.\n You have " + attempt + " more attempts";
                        attempt--;
                    }
                    else if (attempt == 1)
                    {                        
                        messageBlock.Text = "You did not guess.\n You have " + attempt + " attempt";
                        attempt--;
                    }
                    else
                    {
                        messageBlock.Text = "You did not guess.\nThe number was " + randomeNumber + "\nTo to continue enter a new number.";
                        randomeNumber = rnd.Next(1, 10);
                        attempt = 2;
                    }
                }
                else
                {
                    messageBlock.Text = "Congratulations, you guessed the number!\nTo to continue enter a new number.";
                    randomeNumber = rnd.Next(1, 10);
                    attempt = 2;
                }
            }



        }

        public bool NumberValidation()
        {
            
            bool errorFlag = true;

            if (userNumber.Text == "")
            {
                messageBlock.Text = "Please enter some number";
                errorFlag = false;
            }
            else
            {
                if (StringToInt(userNumber.Text) < 1 ||StringToInt(userNumber.Text) >10)
                {
                    messageBlock.Text = "Your namber must be from 1 to 10 \n";
                    errorFlag = false;
                }

                for (int i = 0; i < userNumber.Text.Length; i++)
                {
                    if (!Char.IsNumber(userNumber.Text[i]))
                    {
                        messageBlock.Text = "Your namber must contain only digits.";
                        errorFlag = false;
                        break;
                    }
                }


            }

            return errorFlag;

        }

        static int StringToInt(string str)
        {
            int userNumber = 0;
            try
            {
                userNumber = Convert.ToInt32(str);
            }
            catch (FormatException)
            {
                Console.WriteLine("Values entered incorrectly");
            }
            return userNumber;
        }
    }
}
