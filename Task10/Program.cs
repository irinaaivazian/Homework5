namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int c = 5;
            

            int largest = a;

            if (b > largest)
            {
                largest = b;
            }
            if (c > largest)
            {
                largest = c;
            }
            

            Console.WriteLine($"{largest} is the largest number.");
        }
    }
    
}
