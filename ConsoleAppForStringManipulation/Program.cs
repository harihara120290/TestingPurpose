using System;
using System.Globalization;
using System.Text;

namespace ConsoleAppForStringManipulation
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            Console.ReadLine();
            //char c = 'g';
            string appname = @"E:\""FULLSTACK WEBSHOP";
            
            //char[] c1 = s.ToCharArray();
            //s = s + "hdhhd";
            //Console.WriteLine("Hello World!");
            //// string s = "hari";
            //Console.ReadLine();
            Console.WriteLine("Hashcode test of String:");
            String str = "csharp";
            Console.WriteLine("HashCode value of 'csharp': " + str.GetHashCode());
            str = str + "community";
            Console.WriteLine("HashCode value of 'community': " + str.GetHashCode());
            str = str + "members";
            Console.WriteLine("HashCode value of 'members': " + str.GetHashCode());

            Console.WriteLine("Hashcode test of StringBuilder:");
            StringBuilder strbuild = new StringBuilder("csharp");
            Console.WriteLine("HashCode value of 'csharp': " + strbuild.GetHashCode());
            strbuild.Append("community");
            Console.WriteLine("HashCode value of 'community': " + strbuild.GetHashCode());
            strbuild.Append
                ("members");
            Console.WriteLine("HashCode value of 'members': " + strbuild.GetHashCode());

            long startTime = System.DateTime.Now.Millisecond;
            StringConcat();
            Console.WriteLine("Time taken for StringConcat: " + (System.DateTime.Now.Millisecond - startTime) + "ms");
            startTime = System.DateTime.Now.Millisecond;
            StringBufferConcat();
            Console.WriteLine("Time taken for StringBuilderConcat: " + (System.DateTime.Now.Millisecond - startTime) + "ms");
            Console.ReadLine();
        }
        public static String StringConcat()
        {
            String str = "hari";
            //for (int i = 0; i < 10000; i++)
            //{
            //    str = str + "hara";
            //}
            return str;
        }
        public static String StringBufferConcat()
        {
            StringBuilder strBuff = new StringBuilder("hari");
           
            //for (int i = 0; i < 10000; i++)
            //{
            //    strBuff.Append("hara");
            //}
            return strBuff.ToString();
        }
    }
}
