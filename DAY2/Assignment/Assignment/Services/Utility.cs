using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Services
{
    internal class Utility
    {

        int a, b;
        public void run()
        {

            Console.WriteLine("result of the addition is : " + UtilityMethods.Add(10, 5));
            Console.WriteLine("result of the multiplication : " +UtilityMethods.Multiply(5)); 

            UtilityMethods.Divide(10,5, out int divresult);
            Console.WriteLine("result of the division is : "+divresult);


        }



    }
    class UtilityMethods {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Multiply(int a, int b = 10)
        {
            return a * b;
        }
        public static void Divide(int a, int b, out int result)
        {
            result = a / b;
        }
    }

}
