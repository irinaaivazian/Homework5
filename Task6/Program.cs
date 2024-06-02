namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "start";
            switch (command) 
            {
                case "start":
                    Console.WriteLine("Started");
                    break;
                case "stop":
                    Console.WriteLine("Stopped");
                    break;
                case "pause":
                    Console.WriteLine("Paused");
                    break;
                case "resume":
                    Console.WriteLine("Resumed");
                    break;
                default:
                    Console.WriteLine("Invalid command. Please use only 'start', 'stop', 'pause', 'resume' commands.");
                    break;
            }
        }
    }
}
