namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 3;

            if (number % 2 == 0)
            {
                Console.WriteLine($"The {number} is even.");
            }
            else 
            {
                Console.WriteLine($"The {number} is odd.");
            }
        }
    }
}
