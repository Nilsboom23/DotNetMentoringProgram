using System;

namespace ClassLibrary2
{
    public class HelloWorld
    {
        public static string GetHelloWorldString(string username)
        {
            var currentTime = DateTime.Now.ToString("HH:mm:ss");
            return $"{currentTime} Hello, {username}!";
        }
    }
}