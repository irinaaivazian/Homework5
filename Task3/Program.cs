using System.ComponentModel;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 166;

            if (number > 0)
            {
                if (number < 50)
                {
                    Console.WriteLine($"The {number} is greater than 0 and less than 50.");
                }
                else 
                {
                    Console.WriteLine($"The {number} is greater than 0 but not less than 50.");
                }
            }
            else
            {
                if (number < 50)
                {
                    Console.WriteLine($"The {number} is not greater than 0 and less than 50.");
                }
                else
                {
                    Console.WriteLine($"The {number} is not greater than 0 but not less than 50.");
                }
            }
        }
    }
}
