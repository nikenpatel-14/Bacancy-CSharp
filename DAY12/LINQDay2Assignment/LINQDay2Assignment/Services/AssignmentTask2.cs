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
        }
    }
}
