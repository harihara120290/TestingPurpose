#define xyz
using System;
using System.Collections.Generic;
using System.Text;



namespace ConsoleAppForStringManipulation
{
  
    class PreprocessorExample
    {
        public const bool debugvariable = true;

        //        static void Main()
        //        {
        //#if debug 
        //            //#error DEBUG is defined

        //            Console.WriteLine("Debugging is enabled.");
        //            Console.ReadLine();
        //#endif

        //#if RELEASE
        //                        Console.WriteLine("Tracing is enabled.");
        //                        Console.ReadLine();
        //#endif
        //            Console.WriteLine("No condition satisfied");
        //            Console.ReadLine();
        ////#warning disable 14, CS0219 

        //        }
        //        static void Main()
        //        {
        //#line 200 "Special"
        //            int i;
        //            int j;
        //#line default
        //            char c;
        //            float f;
        //#line hidden // numbering not affected
        //            string s;
        //            double d;
        //        }
        static void Main88888()
        {
            global::System.Console.WriteLine("Normal line #1."); // Set break point here.
#line hidden
            Console.WriteLine("Hidden line.");
            Console.WriteLine("Hidden line1.");

            Console.WriteLine("Normal line #2.");
            Console.ReadLine();
        }
    }

}
