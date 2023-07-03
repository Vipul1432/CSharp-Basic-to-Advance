namespace Practical_7.LSP_Follow
{
    // Following the Liskov Substitution Principle    

    public interface IFileReader
    {
        void ReadFile(string filePath);
    }

    public interface IFileWriter
    {
        void WriteFile(string filePath);
    }

    public class AdminDataFileUserFixed : IFileReader, IFileWriter
    {
        public void ReadFile(string filePath)
        {
            // Read File logic    
            Console.WriteLine($"File {filePath} has been read");
        }

        public void WriteFile(string filePath)
        {
            //Write File Logic    
            Console.WriteLine($"File {filePath} has been written");
        }
    }

    public class RegularDataFileUserFixed : IFileReader
    {
        public void ReadFile(string filePath)
        {
            // Read File logic    
            Console.WriteLine($"File {filePath} has been read");
        }
    }
}
