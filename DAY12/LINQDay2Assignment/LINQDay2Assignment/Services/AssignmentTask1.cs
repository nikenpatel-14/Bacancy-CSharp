using LINQDay2Assignment.Model;
using LINQDay2Assignment.SampleData;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDay2Assignment.Services
{
    internal class AssignmentTask1
    {
        public static void Run()
        {

            Console.WriteLine("----TASK1----");
            //Creating sample list of employee for operations
            List<Employee> employees = SampleData.SampleData.SampleEmpData();

            //LINQ feature : Max
            //Max() is aggregate function which return the maximum value from the data
            var HighestSal = employees.Max(x => x.EmpSalary);
            Console.WriteLine($"HIGHEST SALARY OF EMPLOYEE IS : {HighestSal}");


            //LINQ feature : Min
            //Min() is aggregate function which return the minimum value from the data
            var LowestSal = employees.Min(x => x.EmpSalary);
            Console.WriteLine($"LOWEST SALARy OF EMPLOYEE IS : {LowestSal}");


            //LINQ feature : Sum
            //Sum() is aggregate function which return the sum of input values from the data
            var TotalSal = employees.Sum(x => x.EmpSalary);
            Console.WriteLine($"TOTAL SALARY OF EMPLOYEE IS : {TotalSal}");


            //LINQ feature : Average
            //Average() is aggregate function which return the average of the input data 
            var AvgSal = employees.Average(x => x.EmpSalary);
            Console.WriteLine($"AVERAGE SALARY OF EMPLOYEE IS : {AvgSal}");


            //LINQ feature : Count,GroupBy,Select
            //count() is aggregate function which return the count from the data
            //in this case it returns the total num of employes in list (for each department using GroupBy)
            //Group by : It used to do grouping of the data based on specific param, in this case we group by department
            var Empcount = employees.GroupBy(x => x.Department).Select(x => new { Department = x.Key,Employeecount = x.Count()});

            foreach (var count in Empcount)
            {
                Console.WriteLine(count);
            }


        }
    }
}
