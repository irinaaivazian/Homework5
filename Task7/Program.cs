namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 22;
            bool hasLicense = false;

            if (age >= 18)
            {
                if (hasLicense)
                {
                    Console.WriteLine("Can drive.");
                }
                else 
                {
                    Console.WriteLine("Cannot drive because doesn't have license.");
                }
            }
            else
            {
                Console.WriteLine("Can't drive because of age.");
            }
        }
    }
}
