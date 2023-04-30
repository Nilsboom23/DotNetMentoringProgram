using System;
using Module_1_SampleLibrary;

namespace Module1_ConsoleApp
{
    internal class HelloUser
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                string username = args[0];

                //Without using sample_Library
                // Console.WriteLine($"Hello, {username}!");

                //using sample_Library
                string helloWorldString = HelloWorld.GetHelloWorldString(username);
                Console.WriteLine(helloWorldString);
            }
            else
            {
                Console.WriteLine("Please provide a username as a command line argument.");
            }
        }
    }
}


