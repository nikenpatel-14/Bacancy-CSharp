using LINQDay2Assignment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDay2Assignment.Services
{
    internal class AssignmentTask4
    { 
        public static void Run()
        {
            List<Employee> employees = SampleData.SampleData.SampleEmpData();


            var result = employees.Where(x => x.EmpSalary > employees.Average(x => x.EmpSalary));
            foreach(var emp in result)
            {
                Console.WriteLine($"EMPLOYEE NAME : {emp.EmpName} ,EMPLOYEE SALARY : {emp.EmpSalary}");
            }


            var higherthanHr = employees.Where(x =>x.EmpSalary > employees.Where(x=> x.Department == "HR").Max(x => x.EmpSalary));
            Console.WriteLine("\n EMPLOYEES HAVING HIGHER SALARY THEN HR HIGHEST SALARY");
            foreach (var emp in higherthanHr) 
            {
                Console.WriteLine($"EMPLOYEE NAME : {emp.EmpName} , EMPLOYEE SALARY : {emp.EmpSalary}");
            }




        }

    }
}
