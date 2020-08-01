using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForStringManipulation
{
    class interpolation
    {
        static void Main1(string[] args)
        {
            var msg = $".NET Version: {Environment.Version}";
            string name = "Hari";
            int accesses = 10;
            Console.WriteLine(string.Format("{0}, you've been here {1}  times.",
                              name, accesses));

            Console.WriteLine($"{name}, you've been here {DateTime.Now} times.");
            Console.WriteLine($".NET Version: {Environment.Version}");
            Console.ReadLine();
        }
    }
}
