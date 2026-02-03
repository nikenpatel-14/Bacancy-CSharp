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
            List<Employee> employees = SampleData.SampleData.SampleEmpData();


            var HighestSal = employees.Max(x => x.EmpSalary);
            Console.WriteLine($"HIGHEST SALARY OF EMPLOYEE IS : {HighestSal}");

            var LowestSal = employees.Min(x => x.EmpSalary);
            Console.WriteLine($"LOWEST SALARy OF EMPLOYEE IS : {LowestSal}");

            var TotalSal = employees.Sum(x => x.EmpSalary);
            Console.WriteLine($"TOTAL SALARY OF EMPLOYEE IS : {TotalSal}");

            var AvgSal = employees.Average(x => x.EmpSalary);
            Console.WriteLine($"AVERAGE SALARY OF EMPLOYEE IS : {AvgSal}");

            var Empcount = employees.GroupBy(x => x.Department).Select(x => new { Department = x.Key,Employeecount = x.Count()});

            foreach (var count in Empcount)
            {
                Console.WriteLine(count);
            }


        }
    }
}
