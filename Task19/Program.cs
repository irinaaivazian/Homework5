namespace Task19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char xchar = 's';
            switch (xchar)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("vowel");
                    break;
                default:
                    Console.WriteLine("constant");
                    break;
            }
        }
    }
}
