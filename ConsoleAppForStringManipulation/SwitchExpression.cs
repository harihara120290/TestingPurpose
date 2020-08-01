using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForStringManipulation
{
    class SwitchExpression
    {
        public static void Main7(String[] args)
        {
            int gitem = 8;

            switch (gitem)
            {

                case 2:
                case 4:
                    Console.WriteLine("Hello");
                    break;

                case 8:
                    Console.WriteLine("Hari");
                    break;
                case 6:
                    Console.WriteLine("Hara");
                    break;

               

                default:
                    Console.WriteLine("Harihara Acharya");
                    break;
            }

            if (true)
            {
                Console.WriteLine("Hari");
                Console.WriteLine("Hari");
                Console.WriteLine("Hari");
            }

            if (true)
            Console.WriteLine("Hari");

            
            

            
        
        
    }
}
}
