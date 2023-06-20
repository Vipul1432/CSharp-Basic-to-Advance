using E_Bank.Model;
using System.Text.RegularExpressions;

namespace E_Bank
{
    internal static class UserInput
    {
        public static UserModel GiveMeUser(string accountNumber)
        {
            string Name = GetUserName();
            string PhoneNumber = GetPhoneNumber();
            string Password = GetPassword();
            long BankBalance = (long)GetBankBalance();
            int Pin = GetPin();
            return new UserModel(accountNumber, Name, PhoneNumber, Password, BankBalance, Pin);
        }
        private static string GetUserName()
        {
            string UserName;
            do
            {
                Console.Write("Enter user name : ");
                UserName = Console.ReadLine();
            } while (!Regex.IsMatch(UserName, @"^[\p{L} \.\-]+$"));
            return UserName;
        }
        private static string GetPhoneNumber()
        {
            long PhoneNumber;
            do
            {
                Console.Write("Enter 10 digit Mobile Number : ");
            } while (!(long.TryParse(Console.ReadLine(), out PhoneNumber) && PhoneNumber.ToString().Length == 10));
            return PhoneNumber.ToString();
        }
        private static string GetPassword()
        {
            
            Console.Write("Enter password : ");
            string Password = Console.ReadLine();
            while(string.IsNullOrEmpty(Password) || string.IsNullOrWhiteSpace(Password)) 
            {
                Console.WriteLine("Password can't be null and whitespace");
                Password = Console.ReadLine();
            }
            return Password;
        }
        private static long? GetBankBalance()
        {
            long? Amount = null;
            do
            {
                Console.Write("Enter Amount : ");

                try
                {
                    Amount = long.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Amount = null;
                }
            } while (Amount == null);
            return Amount;
        }
        private static int GetPin()
        {
            int Pin;
            do
            {
                Console.Write("Enter 4 digit pin : ");
            } while (!(int.TryParse(Console.ReadLine(), out Pin) && Pin.ToString().Length == 4));
            return Pin;
        }
    }
}
