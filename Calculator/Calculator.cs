namespace Program
{
    public class Calculator
    {
        public static float Add(float x, float y)
        {
            return x + y;
        }
        public static float Sub(float x, float y)
        {
            return x - y;
        }
        public static float Multiply(float x, float y)
        {
            return (x * y);
        }
        public static float Divide(float x, float y)
        {
            return (x / y);
        }

        public static float? PerformOperation(float x, float y, string? option)
        {
            if (String.IsNullOrWhiteSpace(option))
            {
                Console.WriteLine("Please Provide a valid option");
                return null;
            }
            switch (option)
            {
                case "a": return Add(x, y);
                case "s": return Sub(x, y);
                case "m": return Multiply(x, y);
                case "d": return Divide(x, y);
                default:
                    return null;
            }

        }

    }
}