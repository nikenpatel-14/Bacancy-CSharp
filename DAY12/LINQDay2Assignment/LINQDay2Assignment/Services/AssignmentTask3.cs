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

            Console.WriteLine("\n----TASK3----");
            //Creating sample list of employee for operations
            List<Employee> employees = SampleData.SampleData.SampleEmpData();


            // LINQ FEATURE : Groupby,select,average,annonymus type,count
            //group by : heare it used to group by employee based on department
            //select : it used  for projection of the feild
            //Average(): it used to perform average function on salary
            //count() : it used to calculate the count of employee 
            //key : it give the value by which element is grouped
            //annonymus type : it used top getting result with feild departmen name,average salary and employee count
            var Emplist = employees.GroupBy(x => x.Department).Select(x => new { Department = x.Key, AvgSalary = x.Average(n => n.EmpSalary), EmpCount = x.Count() });

            foreach (var emp in Emplist)
            {
                Console.WriteLine($"DEPARTMENT Name = {emp.Department} , AVERAGE SALARY = {emp.AvgSalary} , EMPLOYEE COUNT = {emp.EmpCount}");
            }
        }
    }
}
