namespace Task20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 777;
            int b = 5;
            int c = 8;
            int d = 2;
            int e = 1;

            int smallest = a;
            int largest = a;

            if (b < smallest)
            {
                smallest = b;
            }
            if (c < smallest)
            {
                smallest = c;
            }
            if (d < smallest)
            {
                smallest = d;
            }
            if (e < smallest)
            {
                smallest = e;
            }

            Console.WriteLine($"{smallest} is the smallest number.");

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
            if (e > largest)
            {
                largest = e;
            }

            Console.WriteLine($"{largest} is the largest number.");
        }
    }
}
