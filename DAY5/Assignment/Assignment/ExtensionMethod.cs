using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    internal class ExtensionMethod
    {
        static void Main(string[] args)
        {
            string msg = "this message is example for word count";
            Console.WriteLine(msg);

            Console.WriteLine("total num of words :" + msg.wordCount());
        }


    }
    public static class ExtensionMethodDerived {
        
        public static int wordCount(this string s)
        {

            return s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

    }


}
