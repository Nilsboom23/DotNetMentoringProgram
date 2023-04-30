using System;

namespace Module_1_SampleLibrary
{
    public class HelloWorld
    {
        public static string GetHelloWorldString(string username)
        {
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            return $"{currentTime} Hello, {username}!";
        }
    }
}
