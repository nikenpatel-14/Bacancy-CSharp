using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace Assignment.Services
{
    internal class Calculator
    {

        public int option;
        public double result;
        public bool isCorrect;
        public double a, b;


        public void run()
        {

            int cases;

            Console.WriteLine("1)enter 1 if you want to perform arithematic operation");
            Console.WriteLine("2)enter 2 if you want to perform compound assignment");
            Console.WriteLine("3)enter 3 if you want to perform comparision operation");

            cases = Convert.ToInt32(Console.ReadLine());

            switch (cases)
            {
                case 1:
                    Console.WriteLine("enter the first operand");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter the second operand");
                     b = Convert.ToDouble(Console.ReadLine());
                    arithematicOperation(a, b);
                    Console.WriteLine($"result of the  operation is {result}");
                    break;
                case 2:
                    Console.WriteLine("enter the value ");
                    a = Convert.ToDouble(Console.ReadLine());
                    compoundAssignment(a);
                    Console.WriteLine($"result of the  operation is {result}");
                    break;
                 case 3:
                    Console.WriteLine("enter the first operand");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("enter the second operand");
                    b = Convert.ToDouble(Console.ReadLine());
                    comparisionOperator(a ,b);
                    Console.WriteLine($"result of the  operation is {isCorrect}");
                    break;
                default:
                    Console.WriteLine("enter the valid input");
                    break;

            }
            


        }


         public void arithematicOperation(double a, double b)
        {
            Console.WriteLine("1)enter 1 for + operation");
            Console.WriteLine("2)enter 2 for - operation");
            Console.WriteLine("3)enter 3 for * operattion");
            Console.WriteLine("4)enter 4 for / operation");
            Console.WriteLine("5)enter 5 for % operation");

             option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {
                case 1:
                    result = a + b;
                    break;
                case 2:
                    result = a - b;
                    break;
                case 3:
                    result = a * b;
                    break;
                case 4:
                    result = a / b;
                    break;
                 case 5:
                    result = a % b;
                    break;
                default:
                    Console.WriteLine("enter the valid input");
                    break;

            }

        }
        public void compoundAssignment(double a)
        {
            Console.WriteLine("enter the value you want to add or substract");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1)enter 1 for += operation ");
            Console.WriteLine("2)enter 2 for -= operation");
            Console.WriteLine("3)enter 3 for *= operation");
            Console.WriteLine("4)enter 4 for /= operation");
            Console.WriteLine("5)enter 5 for %= operation");

            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    result = a += b;
                    break;
                case 2:
                    result = a -= b;
                    break;
                case 3:
                    result = a *= b;
                    break;
                case 4:
                    result = a /= b;
                    break;
                case 5:
                    result = a %= b;
                    break;
                default:
                    Console.WriteLine("enter the valid input");
                    break;

            }
        }
        public void comparisionOperator(double a, double b)
        {
            
            Console.WriteLine("1)enter 1 to check == operation ");
            Console.WriteLine("2)enter 2 to check <= operation");
            Console.WriteLine("3)enter 3 to check >= operation");
            Console.WriteLine("4)enter 4 to check < operation");
            Console.WriteLine("5)enter 5 to check  > operation");

            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    isCorrect = (a==b);
                    break;
                case 2:
                    isCorrect = (a <= b);
                    break;
                case 3:
                    isCorrect = a >= b;
                    break;
                case 4:
                    isCorrect = a < b;
                    break;
                case 5:
                    isCorrect = a > b;
                    break;
                default:
                    Console.WriteLine("enter the valid input");
                    break;

            }
        }
    }
}
