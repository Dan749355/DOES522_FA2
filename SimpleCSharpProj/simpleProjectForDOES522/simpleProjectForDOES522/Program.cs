using System;

namespace simpleProjectForDOES522
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}, I am a simple program!", name);
        }
    }
}
