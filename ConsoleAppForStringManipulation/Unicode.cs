using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleAppForStringManipulation
{
    class Unicode
    {
        static void Main5(string[] args)
        {
            Console.WriteLine("Hello, world!".ToUnicodeString());
            // Console.WriteLine(Extension.DecodeFromUtf8("Hello, world!".ToUnicodeString()));
            
            Console.ReadLine();

        }
    }
    public static class Extension
    {
        public static string ToUnicodeString(this string str)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var c in str)
            {
                sb.Append("\\u" + ((int)c).ToString("X4"));
            }
            return sb.ToString();
        }
        public static string DecodeFromUtf8(this string utf8String)
        {
            // copy the string as UTF-8 bytes.
            byte[] utf8Bytes = new byte[utf8String.Length];
            for (int i = 0; i < utf8String.Length; ++i)
            {
                //( 0 <= utf8String[i] && utf8String[i] <= 255, "the char must be in byte's range");
                utf8Bytes[i] = (byte)utf8String[i];
            }

           // return Encoding.UTF8.GetString(utf8Bytes, 0, utf8Bytes.Length);
            return "";
        }
    }
}
