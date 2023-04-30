using System;

namespace Module1_ConsoleApp
{
    internal class HelloUser
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string username = args[0];
                Console.WriteLine($"Hello, {username}!");
            }
            else
            {
                Console.WriteLine("Please provide a username as a command line argument.");
            }
        }
    }
}
