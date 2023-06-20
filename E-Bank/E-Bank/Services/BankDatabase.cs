using E_Bank.Model;

namespace E_Bank.Services
{
    internal class BankDatabase
    {
        private List<UserModel> users = new List<UserModel>();
        
        public List<UserModel> GetUserList()
        {
            return users;
        }
        public bool AddUsers(UserModel user)
        {
            users.Add(user);
            return true;
        }
        

    }
}
