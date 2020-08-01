using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForStringManipulation
{
    class Verbatim
    {
        static void Main88(string[] args)
        {
            //1.
            string[] @for = { "C#", "PHP", "Java", "Python" };

           // use of @ by using keyword
            // as an identifier 
            foreach (string @as in @for)
            {
                Console.WriteLine("Element of Array: {0}", @as);
                //Console.ReadLine();
            }

            //2.
            // If you use the below commented 
            // the part then this will give 
            // Unrecognized escape sequence error 
           
            // By using @ in the given string  
            // it runs smoothly because 
            // @ symbol tells the compiler to 
            // ignore all escape sequences 
            string S2 = @"\\welcome \to Dotnetteam \ njoy \";
            Console.WriteLine("String 2 is: {0}", S2);

            // printing new line character in string literal 
            // but it will make the string to break   
            // into a new line
            string S3 = "This is \n C# non verbatim string";
            Console.WriteLine("String 3 is :{0}", S3);
            
            // By using @ symbol /n does not processed 
            string S4 = @"This is \n C# verbatim string";
            Console.WriteLine("String 4 is :{0}", S4);

            // printing a string literal contains  
            // tabs and new line without using  
            // any escape sequence 
            Console.WriteLine(@"Without Tab Sequence and New Line Character 
                               C          C++      Java       Python");
            Console.ReadLine();
        }
}
}
