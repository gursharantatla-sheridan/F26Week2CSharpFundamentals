namespace F26Week2CSharpFundamentals
{
    internal class Program
    {
        static int x;

        static void Main(string[] args)
        {
            int @double = 5;

            int i = 5;
            double d = 5.5;

            float f = 5.5F;
            decimal m = 5.5M;
            long l = 43534L;

            //int x;
            i = x + 5;
            Console.WriteLine(i);

            var n = 5;


            Console.WriteLine(@"Hello\nworld");
            Console.WriteLine("\n\n");


            int cars = 5, bikes = 7, trucks = 10;

            // string concatenation
            Console.WriteLine("I have " + cars + " cars, " + bikes + " bikes and " + trucks + " trucks");

            // string interpolation
            Console.WriteLine($"I have {cars} cars, {bikes} bikes and {trucks} trucks");
        }
    }
}
