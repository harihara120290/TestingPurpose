using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleAppForStringManipulation
{
    class Encodings
    {
        private static void Main55()
        {
            try
            {
                const string myTeamNamesFile = @"E:\FULLSTACK WEBSHOP\MyTeamName1.txt";

                // Open the text file using a stream reader.
                using (var streamReader = new StreamReader(myTeamNamesFile,Encoding.ASCII))
                {
                   
                        // Read the stream to a string, and write the string to the console.
                        var line = streamReader.ReadToEnd();
                    Console.WriteLine(line);
                    
                    Console.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }
    }
}
