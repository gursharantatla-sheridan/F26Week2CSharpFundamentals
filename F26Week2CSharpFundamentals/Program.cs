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

            Console.WriteLine("\n\n");



            // value and reference types

            int a = 5;
            int b = a;

            a++;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("\n");


            Circle c1 = new Circle();
            Console.WriteLine(c1.radius);

            c1.radius = 50;

            Circle c2 = c1;
            //Circle c2 = new Circle();

            Console.WriteLine(c1.radius);
            Console.WriteLine(c2.radius);

            c2.radius = 100;

            Console.WriteLine(c1.radius);
            Console.WriteLine(c2.radius);

            Console.WriteLine("\n\n");


            // string example
            string s1 = "hello";
            string s2 = s1;

            Console.WriteLine(s1);
            Console.WriteLine(s2);

            s2 = "bye";

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }

    class Circle
    {
        public int radius;
    }
}
