

using E_Bank.Interfaces;
using Microsoft.VisualBasic.FileIO;

namespace E_Bank.UI
{
    internal class Paytm : IPaymentProcess
    {
        public int ChooseUPIOption()
        {
            int UPIOption;
            do       
            {
                Console.WriteLine("********** Select Your choice *********");
                Console.WriteLine("1. Create UPI id");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                UPIOption = Convert.ToInt32(Console.ReadLine());
            } while (!(int.TryParse(Console.ReadLine(), out UPIOption) && UPIOption <= 3 && UPIOption >= 1));
            return UPIOption;
        }
    }
    internal class Login
    {
        public string UPIid { get; set; }
        public string AccessKey { get; set; }
    }
}
