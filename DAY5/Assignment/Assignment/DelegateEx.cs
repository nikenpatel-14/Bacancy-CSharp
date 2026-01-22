using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    internal class DelegateEx
    {
        public delegate void MyDel(string msg);

        public static void Hello1(string msg)
        {
            Console.WriteLine("Hello 1 called : "+msg);
        }
        public static void Hello2(string msg) {

            Console.WriteLine("Hello 2 called : "+msg);
        }

        static void Main(string[] args)
        {
            MyDel md = Hello1;
            md("this is delegate");
            md += Hello2;
            md.Invoke("it called twice");

            Console.WriteLine("removing one method from delegate");
            md -= Hello1;
            md("it called only once");
        
        }
    }
}
