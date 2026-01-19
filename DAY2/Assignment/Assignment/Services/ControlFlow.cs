using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Services
{
    internal class ControlFlow
    {

        int marks;
        public void run()
        {
            Console.WriteLine("enter your marks");
            marks = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("if else ladder ");
            ifelseFlow(marks);
            Console.WriteLine("switch case ");
            switchFlow(marks);
        }

        void ifelseFlow(int marks)
        {
            if (marks <= 33)
            {
                Console.WriteLine("sorry,you do noit pass the exam");
            }
            else if (33 < marks  && marks <= 50)
            {
                Console.WriteLine("you have passed the exam with D grade");

            }
            else if(50 < marks && marks <= 65)
            {
                Console.WriteLine("you have passed the exam with C grade");
            }
            else if(65< marks && marks <= 80)
            {
                Console.WriteLine("you have passed the exam with B grade");
            }
            else if(80< marks && marks <=100)
            {
                Console.WriteLine("you have passed the exam with A grade");
            }

        }
        void switchFlow(int marks)
        {

            switch (marks)
            {
                case  <= 33:
                    Console.WriteLine("sorry,you do noit pass the exam");
                    break;
                case int m when (m > 33 && m <= 50):
                     Console.WriteLine("you have passed the exam with D grade");
                    break;
                case int m when (m > 50 && m <= 65):
                    Console.WriteLine("you have passed the exam with C grade");
                    break;
                case int m when (m > 65 && m <= 80):
                    Console.WriteLine("you have passed the exam with B grade");
                    break;
                case int m when (m > 80 && m <=100):
                    Console.WriteLine("you have passed the exam with  A grade");
                    break;
                default:
                    Console.WriteLine("enter valid marks");
                    break ;

            }


        }
    }
}
