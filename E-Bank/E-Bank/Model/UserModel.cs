namespace E_Bank.Model
{
    public class UserModel
    {
        private string _password;
        private long _bankBalance;
        private int _pin;
        public string AccountNumber { get; init; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public UserModel(string accountNo, string name, string phoneNumber, string password, long bankBalance, int pin)
        {
            _password = password;
            AccountNumber = accountNo;
            Name = name;
            PhoneNumber = phoneNumber;
            _bankBalance = bankBalance;
            _pin = pin;
        }

        public bool UpdatePassword(string oldPassword, string newPassword)
        {
            if (oldPassword == _password)
            {
                _password = newPassword;
                return true;
            }
            return false;
        }

        public bool UserValidate(string accountNo, string password)
        {
            //List<UserModel> users = new List<UserModel>();
            //foreach (var item in users)
            //{
            //    if (item.AccountNumber == accountNo && item._password == password)
            //    {
            //        return true;
            //    }
            //}
            if(_password == password && this.AccountNumber == accountNo)
            {
                return true;
            }
            return false;
        }
        public bool ValidatePin(string accountNo, int pin)
        {
            if(accountNo == AccountNumber && _pin == pin)
            {
                return true;
            }
            return false;
        }
        public long GetBankBalance()
        {
            return _bankBalance;
        }
        public void SetBalance(long bankBalance)
        {
            _bankBalance = bankBalance;
        }

    }
}
