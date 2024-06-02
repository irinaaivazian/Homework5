namespace Task17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            int b = 2;
            int c = 3;

            if (a == b && a == c)
            {
                Console.WriteLine("The triangle is equilateral.");
            }
            else if (a == b || b == c || a == c)
            {
                Console.WriteLine("The triangle is isosceles");
            }
            else
            {
                Console.WriteLine("The triangle is scalene");
            }



        }
    }
}
