namespace Task13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grade = 5;

            if (grade == 5) 
            {
                Console.WriteLine("Excellent");
            }
            else if (grade == 4)
            {
                Console.WriteLine("Good");
            }
            else if (grade == 3)
            {
                Console.WriteLine("Average");
            }
            else if (grade == 2)
            {
                Console.WriteLine("Poor");
            }
            else if (grade == 1)
            {
                Console.WriteLine("Fail");
            }
            else 
            {
                Console.WriteLine("Invalid grade");
            }
        }
    }
}
