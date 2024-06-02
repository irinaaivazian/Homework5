namespace Task16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 777;
            int y = 5;
            int z = 8;
            int w = 2;

            int smallest = x;

            if (y < smallest)
            {
                smallest = y;
            }
            if (z < smallest)
            {
                smallest = z;
            }
            if (w < smallest) 
            {
                smallest = w;
            }

            Console.WriteLine($"{smallest} is the smallest number.");

            //if (x < y && x < z && x < w)
            //{
            //    Console.WriteLine("x is the smallest");
            //}
            //else if (y < x && y < z && y < w)
            //{
            //    Console.WriteLine("y is the smallest");
            //}
            //else if (z < x && z < y && z < w)
            //{
            //    Console.WriteLine("z is the smallest");
            //}
            //else 
            //{
            //    Console.WriteLine("w is the smallest");
            //}

        }
    }
}
