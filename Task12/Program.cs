namespace Task12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = -899;
            if (num != 0 && num > 0) 
            {
                Console.WriteLine($"The {num} is positive.");
            }
            else if (num != 0 && num < 0) 
            {
                Console.WriteLine($"The {num} is negative.");
            }
            else 
            {
                Console.WriteLine($"The {num} is zero.");
            }
        }
    }
}
