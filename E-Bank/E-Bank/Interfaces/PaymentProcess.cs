
namespace E_Bank.Interfaces
{
    interface IPaymentProcess
    {
        public int ChooseUPIOption();
    }
    interface IUPIidGenerator
    {
        public string UPIidGenerate(int phoneNo, int upiPin);
        public void Login(string UpiId, int upiPin);
    }
}
