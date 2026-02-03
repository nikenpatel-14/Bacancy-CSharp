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
            List<EmployeeJoin> employeeJoins = SampleData.SampleData.SampleEmployeeJoin();
            List<Department> departments = SampleData.SampleData.SampleDepData();

            var EmpList = employeeJoins.Join(departments, e => e.DepID, d => d.Id, (e, d) => new { e.EmpName, d.DepartmentName });
            foreach(var emp in EmpList)
            {
                Console.WriteLine($"EMPLOYEE NAME : {emp.EmpName}  , DEPARTMENT NAME : {emp.DepartmentName}");
                
            }
        }
    }
}
