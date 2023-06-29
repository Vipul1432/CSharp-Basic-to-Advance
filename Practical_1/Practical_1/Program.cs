namespace Practical_1
{
    class Program
    {
        static string backValue = string.Empty;
        static double value;
        static ConsoleKeyInfo inputKey;

        static void Main(string[] args)
        {
            Console.Title = "";
            Console.Write("Enter your value: ");
            ValidateNumber();
            backValue = string.Empty;
            value = 0;
            Console.Write("Enter your value: ");
            ValidateNumber();

            if (double.TryParse(backValue, out value))
                if

            Console.ReadKey();
        }

        public static void ValidateNumber()
        {
            do
            {
                inputKey = Console.ReadKey(true);

                if (char.IsDigit(inputKey.KeyChar))
                {
                    if (inputKey.KeyChar == '0')
                    {
                        if (!backValue.StartsWith("0") || backValue.Contains('.'))
                            Write();
                    }

                    else
                        Write();
                }

                if (inputKey.KeyChar == '-' && backValue.Length == 0 ||
                    inputKey.KeyChar == '.' && !backValue.Contains(inputKey.KeyChar) &&
                    backValue.Length > 0)
                    Write();

                if (inputKey.Key == ConsoleKey.Backspace && backValue.Length > 0)
                {
                    backValue = backValue.Substring(0, backValue.Length - 1);
                    Console.Write("\b \b");
                }
                // Loop until Enter key not pressed
            } while (inputKey.Key != ConsoleKey.Enter);
        }

        static void Write()
        {
            backValue += inputKey.KeyChar;
            Console.Write(inputKey.KeyChar);
        }
    }
}