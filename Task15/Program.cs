namespace Task15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 73;
            int c = 280;
            int d = 44;

            int largest = a;

            if (b > largest)
            {
                largest = b;
            }
            if (c > largest)
            {
                largest = c;
            }
            if (d > largest)
            {
                largest = d;
            }

            Console.WriteLine($"{largest} is the largest number.");
        }
    }
}
