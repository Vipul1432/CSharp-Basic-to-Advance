namespace Practical_7.LSP_Follow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling class following Liskov Substitution Principle  

            IFileReader fileReader = new AdminDataFileUserFixed();
            fileReader.ReadFile(@"c:\temp\a.txt");

            IFileWriter fileWriter = new AdminDataFileUserFixed();
            fileWriter.WriteFile(@"c:\temp\a.txt");

            IFileReader fileReaderR = new RegularDataFileUserFixed();
            fileReaderR.ReadFile(@"c:\temp\a.txt");
        }
    }
}
