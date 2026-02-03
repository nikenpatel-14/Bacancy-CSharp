using LINQDay2Assignment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDay2Assignment.Services
{
    internal class AssignmentTask2
    {
        public static void Run()
        {

            Console.WriteLine("\n----TASK2----");
            //sample data for employee and department
            List<EmployeeJoin> employeeJoins = SampleData.SampleData.SampleEmployeeJoin();
            List<Department> departments = SampleData.SampleData.SampleDepData();


            //LINQ feature Used : Join , annonymus type
            // join is used to perform join operation on two collections/dbtable Here we take one table employe which has
            // feild name depID which mapped to Department model Id it gives the mapeed result Inner Join
            // annonymus type has been used to get empname and depname 
            var EmpList = employeeJoins.Join(departments, e => e.DepID, d => d.Id, (e, d) => new { e.EmpName, d.DepartmentName });
            foreach(var emp in EmpList)
            {
                Console.WriteLine($"EMPLOYEE NAME : {emp.EmpName}  , DEPARTMENT NAME : {emp.DepartmentName}");
                
            }


            //Linq Feature : Groupjoin, selectmany
            //select many : it used to flatten the list of employees and access empname by parant child pairing (x,d)
            //Groupjoin : it gives heararchial result int his case Department -> employees

            Console.WriteLine("Perform group join");
            var EmpGroup = departments.GroupJoin(employeeJoins, d => d.Id, e => e.DepID, (d, e) => new { Department = d.DepartmentName, Employees = e })
                          .SelectMany(x=> x.Employees, (x, d) => new {Department = x.Department , Employees = d.EmpName , Empsalary = d.EmpSalary});
            foreach(var emp in EmpGroup)
            {
                Console.WriteLine($"DEPARTMENT NAME : {emp.Department} ,EMPLOYEE NAME: {emp.Employees} , EMPLOYEE SALARY : {emp.Empsalary}");
            }
        }
    }
}
