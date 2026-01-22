using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    internal class DelegateEx
    {
        public delegate void MyDel(string msg);

        public static void displayMsg1(string msg)
        {
            Console.WriteLine(msg);
        }
        public static void displayMsg2(string msg) {

            Console.WriteLine(msg);
        }

        static void Main(string[] args)
        {
            MyDel md = displayMsg1;
            md("this is delegate");
            md += displayMsg2;
            md.Invoke("it called twice");

            Console.WriteLine("removing one method from delegate");
            md -= displayMsg1;
            md("it called only once");
        
        }
    }
}
