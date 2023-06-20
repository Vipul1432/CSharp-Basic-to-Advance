using E_Bank.Services;
namespace E_Bank.UI
{
    internal static class BankUI
    {
        public static void GetBank()
        {
            int BankOption;
            Bank bank = new Bank();
            do
            {
                Console.WriteLine("\n************ Welcome to Mybank ************\n");
                Console.WriteLine("Choosee 1, 2, 3\n");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit\n");
            } while (!(int.TryParse(Console.ReadLine(), out BankOption) && BankOption <= 3 && BankOption >= 1));
            GetBankOption(BankOption);
        }
        public static void GetBankOption(int BankOption)
        {
            switch (BankOption)
            {
                case 1:
                    Console.WriteLine("hiiiiiiiiii");
                    CreateBankAccount();
                    break;
                case 2:
                    Console.WriteLine("hello");
                    BankAccountLogin();
                    break;
                case 3:
                    Exit();
                    break;
                default:
                    break;
            }
            GetBank();
        }
        public static void CreateBankAccount()
        {
            Bank bank = new Bank();
            string AccountNumber = bank.CreateAccount();
            Console.WriteLine($"Account Created Succesfully\n");
            Console.WriteLine($"Your Account Number is {AccountNumber}");
        }
        public static void BankAccountLogin()
        {
            bool IspasswordMatch;
            string AccountNumber;
            do
            {
                Bank bank = new Bank();
                Console.Write("Enter Account Number : ");
                AccountNumber = Console.ReadLine();
                Console.WriteLine("Enter Password : ");
                string Password = Console.ReadLine();
                IspasswordMatch = bank.ValidateUser(AccountNumber, Password);
            } while (!IspasswordMatch); 
            LoginAccountOptions(AccountNumber);
        }
        public static bool Exit()
        {
            return true;
        }
        public static void LoginAccountOptions(string accountNumber)
        {
            int AccountOptions;
            do
            {
                Console.WriteLine($"Successful login {accountNumber}\n");
                Console.WriteLine("Choose Option\n");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Add Money");
                Console.WriteLine("3. Transfer Money"); 
                Console.WriteLine("4. Get All Details");
            } while (!(int.TryParse(Console.ReadLine(), out AccountOptions) && AccountOptions <= 4 && AccountOptions >= 1)); SelectOptions(AccountOptions, accountNumber);
        }
        public static void SelectOptions(int accoumtOptions, string accountNumber) 
        { 
            switch (accoumtOptions) 
            { 
                case 1: 
                    CheckBalance(accountNumber); 
                    break; 
                case 2: 
                    AddAmount(accountNumber); 
                    break; 
                case 3: 
                    string receiverAccountNumber = GetReceiverAccountNumber(); 
                    int pin = GetPinInput(); 
                    long amount = GetAmountInput(); 
                    SendMoney(accountNumber, receiverAccountNumber, pin, amount); 
                    break; 
                case 4: 
                    GetAllUsersDetails(accountNumber); 
                    break; 
                default: 
                    break; 
            }
            LoginAccountOptions(accountNumber);
        }
        public static void CheckBalance(string accountNumber) { Bank bank = new Bank(); Console.WriteLine($"Your Current Ammount is : {bank.FetchBankBalance(accountNumber)}"); }
        public static void AddAmount(string accountNumber) { Bank bank = new Bank(); long Amount; do { Console.WriteLine("Enter Ammount to add : "); } while (!(long.TryParse(Console.ReadLine(), out Amount))); bank.AddBankBalance(accountNumber, Amount); Console.WriteLine("Amount Added successfully"); Console.WriteLine($"Now your current Balance is {bank.FetchBankBalance(accountNumber)}"); }
        public static void SendMoney(string accountNumber, string receiverAccountNumber, int pin, long amount) { Bank bank = new Bank(); string Result = bank.TransferAmount(accountNumber, receiverAccountNumber, pin, amount); Console.WriteLine(Result); }
        public static void GetAllUsersDetails(string accountNumber) { Bank bank = new Bank(); bank.GetAccountDetail(accountNumber); }
        public static string GetReceiverAccountNumber() { Bank bank = new Bank(); string ReceiverAccountNumber; bool IsAccountNumberExist; do { Console.Write("Enter receiver Account Number : "); ReceiverAccountNumber = Console.ReadLine(); IsAccountNumberExist = bank.CheckUserAccount(ReceiverAccountNumber); } while (!IsAccountNumberExist); return ReceiverAccountNumber; }
        public static int GetPinInput() { int Pin; do { Console.WriteLine("Enter 4 digit pin : "); } while (!(int.TryParse(Console.ReadLine(), out Pin) && Pin.ToString().Length == 4)); return Pin; }
        public static long GetAmountInput() { long Amount; do { Console.Write("Enter Amount : "); } while (!(long.TryParse(Console.ReadLine(), out Amount))); return Amount; }
    }
}