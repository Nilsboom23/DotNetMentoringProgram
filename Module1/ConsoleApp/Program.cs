using System;
using ClassLibrary2;

internal class HelloUser
{
    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            var username = args[0];

            //without using Library code below
            Console.WriteLine($"Hello, {username}!");

            //Using Library
            var message = HelloWorld.GetHelloWorldString(username);
            Console.WriteLine($"{message}!");
        }
        else
        {
            Console.WriteLine("Please provide a username as a command line argument.");
        }
    }
}