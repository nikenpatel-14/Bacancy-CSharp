using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment
{
    internal class BoxingUnboxing
    {
        static void Main(String[] args)
        {


            int num = 20;


            Console.WriteLine(num);
            object obj = num;

            Console.WriteLine("value after boxing : " + obj);

            num = (int)obj;

            Console.WriteLine("value after unboxing : " + num);
        }

    }
}
