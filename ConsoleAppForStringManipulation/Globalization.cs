using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleAppForStringManipulation
{
    class Globalization
    {
        public static void Main7()
        {
            //Basic
            double val = 1235.56;

            //Console.WriteLine($"Current culture: {CultureInfo.CurrentCulture.Name}");
            //Console.WriteLine(val);

            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-IN");

            Console.WriteLine($"Current culture: {CultureInfo.CurrentCulture.Name}");
            Console.WriteLine(val);
          //  Console.ReadLine();
            //
            List<string> list = new List<string>();

            foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
            {
                string specName = "(none)";
                try { specName = System.Globalization.CultureInfo.CreateSpecificCulture(ci.Name).Name; }

                catch { }
                list.Add(String.Format("{0,-12}{1,-12}{2}", ci.Name, specName, ci.EnglishName));
                
            }

            list.Sort();  // sort by name

            // write to console
            Console.WriteLine("CULTURE   SPEC.CULTURE  ENGLISH NAME");
            Console.WriteLine("--------------------------------------------------------------");
            foreach (string str in list)
                Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
