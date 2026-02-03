using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDay2Assignment.Services
{
    internal class AssignmentTask5
    {
        public static void Run()
        {

            Console.WriteLine("\n----TASK5----");
            //to integer list created for set operation
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, };
            List<int> list2 = new List<int> { 5, 6, 7, 8, 9, 10, 11 };



            //Perform set operation : Intersect()
            //it gives the result which is common in both the list
            Console.WriteLine("ELEMENTS THAT ARE COMMON IN BOTH LIST");
            var listIntersect = list1.Intersect(list2);
            foreach (var item in listIntersect)
            {
                Console.Write(item+ " ");
            }

            //Perform set Operation : Except()
            //it gives the result which is in first list but not in second list
            Console.WriteLine("\nELEMENTS THAT ARE IN FIRST LIST BUT NOT IN SECOND LIST");
            var listExcept = list1.Except(list2);
            foreach(var item in listExcept)
            {
                Console.Write(item + " ");
            }

            //perform set operation : Union()
            //it gives the combined result of both list
            //it implicitly removed the duplicants from the combined list
            Console.WriteLine("\nCOMBINE BOTH LISTS AND REMOVE DUPLICATES");
            var listCmRmDupc = list1.Union(list2);
            foreach( var item in listCmRmDupc)
            {
                Console.Write(item + " ");
            }
        }
    }
}
