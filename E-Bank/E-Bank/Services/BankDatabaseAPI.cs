using E_Bank.Model;

namespace E_Bank.Services
{
    internal static class BankDatabaseAPI
    {
        private static BankDatabase _bankDatabase = new BankDatabase();

        public static bool AddUser(UserModel user)
        {
            if (!CheckUserExist(user))
            {
                return _bankDatabase.AddUsers(user);
            }
            return false;
        }
        private static bool CheckUserExist(UserModel user)
        {
            if (_bankDatabase.GetUserList().Contains(user))
            {
                return true;
            }
            return false;
        }
        public static TransferStatus Transaction(string senderAccountNumber, string receiverAccountNumber, int pin, long amount)
        {
            // Check receiver acccount no
            // validate pin
            // check ammount
            // transfer ammount
            if (IsRecevierAccountValid(receiverAccountNumber))
            {
                return TransferStatus.ReceiverAccountNotValid;
            }
            else if (IsPinValidate(senderAccountNumber, pin))
            {
                return TransferStatus.PinNotValid;
            }
            else if (CheckAmount(senderAccountNumber, amount))
            {
                return TransferStatus.AmmountNotSufficient;
            }
            else
            {
                Transfer(senderAccountNumber, receiverAccountNumber, amount);
                return TransferStatus.Success;
            }
        }
        private static bool IsRecevierAccountValid(string receiverAccountNumber)
        {
            List<UserModel> users = _bankDatabase.GetUserList();
            foreach (UserModel user in users)
            {
                if (user.AccountNumber == receiverAccountNumber)
                {
                    return true;
                }
            }
            return false;
        }
        private static bool IsPinValidate(string senderAccountNumber, int pin)
        {
            List<UserModel> users = _bankDatabase.GetUserList();
            foreach (UserModel user in users)
            {
                if (user.AccountNumber == senderAccountNumber && user.ValidatePin(senderAccountNumber, pin))
                {
                    return true;
                }
            }
            return false;
        }
        private static bool CheckAmount(string senderAccountNumber, long amount)
        {
            List<UserModel> users = _bankDatabase.GetUserList();
            foreach (UserModel user in users)
            {
                if (user.AccountNumber == senderAccountNumber && user.GetBankBalance() > amount)
                {
                    return true;
                }
            }
            return false;
        }
        private static void Transfer(string senderAccountNumber, string receiverAccountNumber, long amount)
        {
            List<UserModel> users = _bankDatabase.GetUserList();
            foreach (UserModel user in users)
            {
                if (user.AccountNumber == senderAccountNumber)
                {
                    user.SetBalance(user.GetBankBalance() - amount);
                }
                if (user.AccountNumber == receiverAccountNumber)
                {
                    user.SetBalance(user.GetBankBalance() + amount);
                }
            }
        }
        public static long FetchBalance(string accountNumber)
        {
            List<UserModel> users = _bankDatabase.GetUserList();
            foreach (UserModel user in users)
            {
                if (user.AccountNumber == accountNumber)
                {
                    return user.GetBankBalance();
                }
            }
            return 0;
        }
        public static long CheckUser(string accountNumber)
        {
            List<UserModel> users = _bankDatabase.GetUserList();
            foreach (UserModel user in users)
            {
                if (user.AccountNumber == accountNumber)
                {
                    return user.GetBankBalance();
                }
            }
            return 0;
        }
        public static List<UserModel> GetAllUsers()
        {
            return _bankDatabase.GetUserList();
        }
    }
}
