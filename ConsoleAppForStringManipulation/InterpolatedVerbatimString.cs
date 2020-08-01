using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppForStringManipulation
{
    class InterpolatedVerbatimString
    {
        static void Main9(string[] args)
        {
            // // Nullable variable 
            // int? element = null;

            // // Using ??= operator 
            // // Assign values to the null variable 
            //// element ??= 400;
            // Console.WriteLine("Element is: {0}", element);
            string email1 = "Strasse";
            string email2 = "Straße";
           bool result= email1.Equals(email2, StringComparison.CurrentCulture);//true
            bool result1 = email1.Equals(email2, StringComparison.OrdinalIgnoreCase);//false
            bool result2 = email1.Equals(email2, StringComparison.InvariantCulture);//true
            bool result3 = email1.Equals(email2, StringComparison.InvariantCultureIgnoreCase);//True
            //bool result = string.Compare(email1,
            //   email2,
            //   StringComparison.InvariantCulture) ==2;
            Console.WriteLine(result );
            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);
            Console.ReadLine();

           
            
        }
    }
}
