

using E_Bank.Model;

namespace E_Bank.Services
{
    internal class Bank
    {
        string AccountNumber = new Random().NextInt64().ToString();
        public string CreateAccount()
        {
            UserModel userModel = UserInput.GiveMeUser(AccountNumber);
            BankDatabaseAPI.AddUser(userModel);
            return AccountNumber;
        }
        public long FetchBankBalance(string accountNumber)
        {

            return BankDatabaseAPI.FetchBalance(accountNumber);
        }
        public void AddBankBalance(string accountNumber, long amount)
        {
            UserModel userModel = UserInput.GiveMeUser(accountNumber);
            userModel.SetBalance(amount + userModel.GetBankBalance());
        }
        public void GetAccountDetail(string AccountNumber)
        {
            UserModel userModel = UserInput.GiveMeUser(AccountNumber);
            Console.WriteLine($"User Name is {userModel.Name}");
            Console.WriteLine($"User Account Number is {userModel.AccountNumber}");
            Console.WriteLine($"User Phone Number is {userModel.PhoneNumber}");
            Console.WriteLine($"User Bank Balance is {userModel.GetBankBalance()}");
        }
        public string TransferAmount(string senderAccountNumber, string receiverAccountNumber, int pin, long amount)
        {
            int Result = (int)BankDatabaseAPI.Transaction(senderAccountNumber, receiverAccountNumber, pin, amount);
            string message = Result switch
            {
                0 => "Receiver Account Not Valid",
                1 => "Pin Not Valid",
                2 => "Ammount Not Sufficient",
                3 => "Ammount Transfered",
                _ => "Invalid Operation"
            };
            return message;
        }
        public bool CheckUserAccount(string accountNumber)
        {
            List<UserModel> users = BankDatabaseAPI.GetAllUsers();
            foreach (var item in users)
            {
                if (item.AccountNumber == accountNumber)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
        public bool ValidateUser(string accountNumber, string password)
        {
            List<UserModel> users = BankDatabaseAPI.GetAllUsers();
            foreach (var item in users)
            {
                if (item.AccountNumber == accountNumber)
                {
                    return item.UserValidate(accountNumber, password); 
                }
            }
            return false;
        }
    }
}
