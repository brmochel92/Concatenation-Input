using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hello: ");
            Console.WriteLine("Brandon Mochel");
            Console.Write("Your Turn!: ");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name);
        }
    }
}
