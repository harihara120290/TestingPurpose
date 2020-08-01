using System;
using System.Collections.Generic;
using System.Text;
// main namespace 
namespace ConsoleAppForStringManipulation
{



    // nested namespace 
    namespace Nest_name
    {

        // class within nested namespace	 
        class Dispaly
        {

            // Constructor of nested 
             
            public Dispaly()
            {

                Console.WriteLine("Nested Namespace Constructor");
                Console.ReadLine();

            }
        }
    }
    
}
// Driver Class 
class Driver
{

    // Main Method 
    public static void Main1(string[] args)
    {


        new ConsoleAppForStringManipulation.Nest_name.Dispaly();

    }
}



