using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;



namespace ConsoleApp1
{
    class XMLOperations
    {
        public static void FindByName(string adress, string name)
        {
            XDocument xdoc = XDocument.Load(adress);            
            XElement Account = xdoc.Element("MobileOperator").Element("Accounts");

            foreach (XElement MobileAccounts in Account.Elements("MobileAccount"))
            {                
                XElement NameElement = MobileAccounts.Element("Name");
                XElement LastNameElement = MobileAccounts.Element("LastName");
                XElement BirthDateElement = MobileAccounts.Element("BirthDate");
                XElement EmailElement = MobileAccounts.Element("Email");
                XElement NumberElement = MobileAccounts.Element("Number");
                if (name == NameElement.Value)
                {
                    Console.WriteLine("Name: {0} Last name: {1} Birth date: {2} Email: {3} Number: {4}", 
                        NameElement.Value, LastNameElement.Value, BirthDateElement.Value,
                        EmailElement.Value, NameElement.Value);
                }
            }
        }

        public static MobileAccount GetByName(string adress, string name)
        {
            XDocument xdoc = XDocument.Load(adress);
            XElement Account = xdoc.Element("MobileOperator").Element("Accounts");

            foreach (XElement MobileAccounts in Account.Elements("MobileAccount"))
            {
                XElement NameElement = MobileAccounts.Element("Name");
                XElement LastNameElement = MobileAccounts.Element("LastName");
                XElement BirthDateElement = MobileAccounts.Element("BirthDate");
                XElement EmailElement = MobileAccounts.Element("Email");
                XElement NumberElement = MobileAccounts.Element("Number");

                if (name == NameElement.Value)
                {
                    MobileAccount user = new MobileAccount();
                    user.Name = NameElement.Value;
                    user.LastName = LastNameElement.Value;
                    user.BirthDate = DateTime.Parse(BirthDateElement.Value);
                    user.Email = EmailElement.Value;
                    user.Number = Int32.Parse(NumberElement.Value);
                    return user;
                }
            }
            return default(MobileAccount);
        }

        public static List<string> Sample(string adress, string fieldName)
        {
            List<string> fields = new List<string>();

            XDocument xdoc = XDocument.Load(adress);
            XElement Account = xdoc.Element("MobileOperator").Element("Accounts");

            foreach (XElement MobileAccounts in Account.Elements("MobileAccount"))
            {
                XElement SomeField = MobileAccounts.Element(fieldName);
                fields.Add(SomeField.Value.ToString());
            }
            return fields;
        }

        public static void AddElementToXML(string adress, MobileAccount user)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load(adress);
            XmlNode accounts = xdoc.DocumentElement.FirstChild;

            XmlElement newElement = xdoc.CreateElement("MobileAccount");

            XmlElement nameElement = xdoc.CreateElement("Name");
            XmlElement lastNameElement = xdoc.CreateElement("LastName");
            XmlElement birthDateElement = xdoc.CreateElement("BirthDate");
            XmlElement emailElement = xdoc.CreateElement("Email");
            XmlElement numberElement = xdoc.CreateElement("Number");

            XmlText nameText = xdoc.CreateTextNode(user.Name);
            XmlText lastNameText = xdoc.CreateTextNode(user.LastName);
            XmlText birthDateText = xdoc.CreateTextNode(user.BirthDate.ToString());
            XmlText emailText = xdoc.CreateTextNode(user.Email);
            XmlText numberText = xdoc.CreateTextNode(user.Number.ToString());

            nameElement.AppendChild(nameText);
            lastNameElement.AppendChild(lastNameText);
            birthDateElement.AppendChild(birthDateText);
            emailElement.AppendChild(emailText);
            numberElement.AppendChild(numberText);

            newElement.AppendChild(nameElement);
            newElement.AppendChild(lastNameElement);
            newElement.AppendChild(birthDateElement);
            newElement.AppendChild(emailElement);
            newElement.AppendChild(numberElement);

            accounts.AppendChild(newElement);

            xdoc.Save(adress);
            Console.WriteLine(user.Name + " was successfully added");
        }

        public static void RemuveByName(string adress, string name)
        {
            XDocument xdoc = XDocument.Load(adress);
            XElement Account = xdoc.Element("MobileOperator").Element("Accounts");

            foreach (XElement MobileAccounts in Account.Elements("MobileAccount"))
            {
                XElement NameElement = MobileAccounts.Element("Name");
                
                if (name == NameElement.Value)
                {
                    MobileAccounts.RemoveAll();
                    Console.WriteLine(name + " was successfully removed");
                }
            }
            xdoc.Save("removed" + adress);
        }
    }
}
