namespace Task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 27;

            if (age >= 0 && age <= 12) 
            {
                Console.WriteLine("Child");
            }
            else if (age >= 13 && age <= 18)
            {
                Console.WriteLine("Teenager");
            }
            else if (age >= 19 && age <= 50)
            {
                Console.WriteLine("Adult");
            }
            else if (age >= 51)
            {
                Console.WriteLine("Senior");
            }
            else 
            {
                Console.WriteLine("Invalid age");
            }
        }
    }
}
