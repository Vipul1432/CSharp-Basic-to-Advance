namespace Practical_7.LSP_Not_Follow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calling class not following Liskov Substitution Principle  

            AccessDataFile accessDataFile = new AdminDataFileUser();
            accessDataFile.FilePath = @"c:\temp\a.txt";
            accessDataFile.ReadFile();
            accessDataFile.WriteFile();

            AccessDataFile accessDataFileR = new RegularDataFileUser();
            accessDataFileR.FilePath = @"c:\temp\a.txt";
            accessDataFileR.ReadFile();
            //accessDataFileR.WriteFile();  // Throws exception  

        }
    }
}
