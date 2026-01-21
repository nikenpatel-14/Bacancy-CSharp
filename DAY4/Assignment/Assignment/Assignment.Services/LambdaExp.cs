using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Assignment.Services
{
    internal class LambdaExp
    {
        public void run()
        {

            //even numbers from the list
            List<int> numbers = new List<int> { 1,5,2,7,3,9,8,6,4};    
            List<int> evenNum = numbers.FindAll(x => x % 2 == 0);

            evenNum.ForEach(x => Console.Write(x));
            Console.WriteLine();


            //maximum value

            int max = numbers.OrderBy(x => x).Last();
            Console.WriteLine("maximum value is : " + max);

            //sorted list

            numbers = numbers.OrderBy(x => x).ToList();
            numbers.ForEach(x => Console.Write(x));


        }


    }
}
