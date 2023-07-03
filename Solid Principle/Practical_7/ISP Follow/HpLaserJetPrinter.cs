namespace Practical_7.ISP_Follow
{
    public class HPLaserJetPrinter : IPrinterTasks, IFaxTasks, IPrintDuplexTasks
    {
        public void Print(string printContent)
        {
            Console.WriteLine("Print Done");
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void Fax(string faxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplex(string printDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }
}
