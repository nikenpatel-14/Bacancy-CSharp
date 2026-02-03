using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDay2Assignment.Services
{
    internal class AssignmentTask5
    {
        public static void Run()
        {
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, };
            List<int> list2 = new List<int> { 5, 6, 7, 8, 9, 10, 11 };



            Console.WriteLine("elements that are common in both lists");
            var listIntersect = list1.Intersect(list2);
            foreach (var item in listIntersect)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("\nelements that are in the first list but not in the second.");
            var listExcept = list1.Except(list2);
            foreach(var item in listExcept)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nCombine both lists and remove duplicates");
            var listCmRmDupc = list1.Union(list2);
            foreach( var item in listCmRmDupc)
            {
                Console.WriteLine(item);
            }
        }
    }
}
