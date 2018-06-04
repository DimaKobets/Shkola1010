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
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            
        }

        private void validationButton_Click(object sender, RoutedEventArgs e)
        {
            FirstNameValidation();
            LastNameValidation();
            DateValidation();
            GenderValidation();
            EmailValidation();
            PhoneNumberValidation();
            InfoValidation();
        }

        private void FirstNameValidation()
        {
            firstNameBlock.Text = "";
            bool errorFlag = true;

            if (firstNameBox.Text == "")
            {
                firstNameBlock.Text = "Please enter your first name";
                errorFlag = false;
            }
            else
            {
                if (firstNameBox.Text.Length > 255)
                {
                    firstNameBlock.Text = "The name is too long.\n";
                    errorFlag = false;
                }

                for (int i = 0; i < firstNameBox.Text.Length; i++)
                {
                    if (!Char.IsLetter(firstNameBox.Text[i]))
                    {
                        firstNameBlock.Text += "The name must contain only letters.";
                        errorFlag = false;
                        break;
                    }
                }
            }

            if (errorFlag)
            {
                firstNameBlock.Text = "✓";
            }

        }

        private void LastNameValidation()
        {
            lastNameBlock.Text = "";
            bool errorFlag = true;

            if (lastNameBox.Text == "")
            {
                lastNameBlock.Text = "Please enter your last name";
                errorFlag = false;
            }
            else
            {
                if (lastNameBox.Text.Length > 255)
                {
                    lastNameBlock.Text = "The  last name is too long.\n";
                    errorFlag = false;
                }

                for (int i = 0; i < lastNameBox.Text.Length; i++)
                {
                    if (!Char.IsLetter(lastNameBox.Text[i]))
                    {
                        lastNameBlock.Text += "The last name must contain only letters.";
                        errorFlag = false;
                        break;
                    }
                }
            }

            if (errorFlag)
            {
                lastNameBlock.Text = "✓";
            }

        }

        private void DateValidation()
        {
            dateBlock.Text = "";
            bool errorFlag = true;
            int[] date = new int[3];

            if (dateBox.Text == "")
            {
                dateBlock.Text = "Please enter your date of birth";
                errorFlag = false;
            }
            if (dateBox.Text.Length < 10)
            {
                dateBlock.Text = "The date must be entered in the format: dd/mm/yyyy";
                errorFlag = false;
            }
            else
            {
                date = StringToInt(SplitString(dateBox.Text));

                if (!(0 < date[0] && date[0] < 32))
                {
                    dateBlock.Text = "The day of your birth date entered wrong.\n";
                    errorFlag = false;
                }
                if (!(0 < date[1] && date[1] < 13))
                {
                    dateBlock.Text += "The month of your birth date entered wrong.\n";
                    errorFlag = false;
                }
                if (!(1900 < date[2] && date[2] < DateTime.Now.Year))
                {
                    dateBlock.Text += "The year of your birth date entered wrong.\n";
                    errorFlag = false;
                }

            }

            if (errorFlag)
            {
                dateBlock.Text = "✓";
            }

        }

        private void GenderValidation()
        {
            genderBlock.Text = "";
            
            if (genderComboBox.SelectedIndex == -1)
            {
                genderBlock.Text = "Choose your gender.";
            }
            else
            {
                genderBlock.Text = "✓";
            }
        }

        private void EmailValidation()
        {
            emailBlock.Text = "";
            bool errorFlag = true;

            if (emailBox.Text == "")
            {
                emailBlock.Text = "Please enter your email";
                errorFlag = false;
            }
            else
            {
                if (!(emailBox.Text.Contains("@")))
                {
                    emailBlock.Text = "You entered the wrong email\n";
                    errorFlag = false;
                }

                if (emailBox.Text.Length > 255)
                {
                    emailBlock.Text += "The email is too long.";
                    errorFlag = false;
                }

            }

            if (errorFlag)
            {
                emailBlock.Text = "✓";
            }
        }

        private void PhoneNumberValidation()
        {
            phoneNumberBlock.Text = "";
            bool errorFlag = true;

            if (phoneNumberBox.Text == "")
            {
                phoneNumberBlock.Text = "Please enter your phone number";
                errorFlag = false;
            }
            else
            {
                if (phoneNumberBox.Text.Length != 12)
                {
                    phoneNumberBlock.Text = "The phone namber must be 12 digits long\n";
                    errorFlag = false;
                }

                for (int i = 0; i < phoneNumberBox.Text.Length; i++)
                {
                    if (!Char.IsNumber(phoneNumberBox.Text[i]))
                    {
                        phoneNumberBlock.Text += "The phone namber must contain only digits.";
                        errorFlag = false;
                        break;
                    }
                }

                
            }

            if (errorFlag)
            {
                phoneNumberBlock.Text = "✓";
            }

        }

        private void InfoValidation()
        {
            infoBlock.Text = "";
            bool errorFlag = true;

            if (infoBox.Text == "")
            {
                infoBlock.Text = "Please enter additional info";
                errorFlag = false;
            }
            else
            {
                if (infoBox.Text.Length > 255)
                {
                    infoBlock.Text = "The  additional info is too long.\n";
                    errorFlag = false;
                }

            }

            if (errorFlag)
            {
                infoBlock.Text = "✓";
            }


        }

        private string[] SplitString(string str)
        {
            string[] split = str.Split(new char[] {'/'});
            return split;
        }

        private int[] StringToInt(string[] splitedString)
        {
            int[] operand = new int[splitedString.Length];
            try
            {
                for (int i=0; i<splitedString.Length; i++)
                operand[i] = Convert.ToInt32(splitedString[i]);                
            }
            catch (FormatException)
            {
                MessageBox.Show("Values entered incorrectly");
            }
            return operand;
        }
    }
}
