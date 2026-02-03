using LINQDay2Assignment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDay2Assignment.Services
{
    internal class AssignmentTask3
    {
        public static void Run()
        {
            List<Employee> employees = SampleData.SampleData.SampleEmpData();

            var Emplist = employees.GroupBy(x => x.Department).Select(x => new { Department = x.Key, AvgSalary = x.Average(n => n.EmpSalary), EmpCount = x.Count() });

            foreach (var emp in Emplist)
            {
                Console.WriteLine($"DEPARTMENT = {emp.Department} , AVERAGE SALARY = {emp.AvgSalary} , EMPLOYEE COUNT = {emp.EmpCount}");
            }
        }
    }
}
