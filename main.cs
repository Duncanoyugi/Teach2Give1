using System;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Practice Program!");
            Helper.DisplayMessage("This is a demonstration of modular code.");
        }
    }

    static class Helper
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}