using System;
using System.Collections.Generic;
using System.Text;

namespace ST10470533_POE1
{
    internal class Response
    {
        // This method collects user details (name) and returns it
        public string Details()
        {
            string name;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("****************************************");
            Console.WriteLine("*      USER DETAILS                    *");
            Console.WriteLine("****************************************");
            Console.ResetColor();

            Console.Write("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine($"Welcome, {name}!");

            return name;

        }
    }
}
