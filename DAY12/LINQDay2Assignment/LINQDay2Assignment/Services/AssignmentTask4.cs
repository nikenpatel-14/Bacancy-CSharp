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

            Console.WriteLine("\n----TASK4----");
            //Creating sample list of employee for operations
            List<Employee> employees = SampleData.SampleData.SampleEmpData();

            //Linq Feature : Where,Average,Nested querry logic
            //where : here it used to apply selection of employee who have higher salary than average
            //Average() : it used to applying aggregate function average on emplopyees salary
            //nested query logic: it means querry inside querry
            //In this case we first written querry to get employee who have salary more than average salaary
            //Inside that we write nested querry which contain the logic of getting average salary
            var result = employees.Where(x => x.EmpSalary > employees.Average(x => x.EmpSalary));
            foreach(var emp in result)
            {
                Console.WriteLine($"EMPLOYEE NAME : {emp.EmpName} ,EMPLOYEE SALARY : {emp.EmpSalary}");
            }
            
            //Linq feature : Where,Max(),nested querry logic
            //Where : here it used both times at first to apply logic employees who have more salary then HR highest salary
            // secondly it used to get employees who have department HR
            // Max() : it used to get maximum salary from HR department
            //Nested Logic : first written querry to get employess data who have higher salary then Hr highest
            //Inside that to get Highest HR salary logic is written
            var higherthanHr = employees.Where(x =>x.EmpSalary > employees.Where(x=> x.Department == "HR").Max(x => x.EmpSalary));
            Console.WriteLine("\n=>EMPLOYEES HAVING HIGHER SALARY THEN HR HIGHEST SALARY :");
            foreach (var emp in higherthanHr) 
            {
                Console.WriteLine($"EMPLOYEE NAME : {emp.EmpName} , EMPLOYEE SALARY : {emp.EmpSalary}");
            }




        }

    }
}
