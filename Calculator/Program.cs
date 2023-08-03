namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            var running = true;
            while (running)
            {
                float? num1 = null;
                float? num2 = null;

                Console.WriteLine("Console Calculator in C#\r");
                Console.WriteLine("------------------------\n");

                Console.WriteLine("Type a number, and then press Enter.");
                var firstInput = Console.ReadLine();

                if (float.TryParse(firstInput, out float firstInputResult))
                {
                    num1 = float.Parse(firstInput);
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Number");
                }

                Console.WriteLine("Type another number, and then press Enter");
                var secondInput = Console.ReadLine();

                if (float.TryParse(secondInput, out float secInputResult))
                {
                    num2 = (float)float.Parse(secondInput);
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Number");
                }

                if (num1 != null && num2 != null)
                {
                    Console.WriteLine("Choose an option from the following list:");
                    Console.WriteLine("\ta - Add");
                    Console.WriteLine("\ts - Subtract");
                    Console.WriteLine("\tm - Multiply");
                    Console.WriteLine("\td - Divide");
                    Console.Write("Your option? ");

                    var operation = Console.ReadLine();

                    var result = Calculator.PerformOperation((float)num1, (float)num2, operation);
                    Console.WriteLine($"Result: {result.ToString()}");
                }
            }
        }
    }
}