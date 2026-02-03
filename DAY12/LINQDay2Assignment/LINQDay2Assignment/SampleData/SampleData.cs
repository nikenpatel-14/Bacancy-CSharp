using LINQDay2Assignment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDay2Assignment.SampleData
{
    internal class SampleData
    {
        public static List<Employee> SampleEmpData()
        {
            return new List<Employee> {
                        new Employee{EmpName = "Mann",EmployeeID = 1, EmpSalary = 50000 , Department = "IT"}
                        ,new Employee{EmpName = "Aayush",EmployeeID = 1, EmpSalary = 40000 , Department = "HR"}
                        ,new Employee{EmpName = "Om",EmployeeID = 1, EmpSalary = 60000 , Department = "HR"}
                        ,new Employee{EmpName = "Smit",EmployeeID = 1, EmpSalary = 70000 , Department = "IT"}
                        ,new Employee{EmpName = "Vishw",EmployeeID = 1, EmpSalary = 50000 , Department = "HR"}
                        ,new Employee{EmpName = "Niken",EmployeeID = 1, EmpSalary = 90000 , Department = "IT"}
            };

        }
        public static List<Department> SampleDepData()
        {
            return new List<Department> {
                new Department{ Id = 1, DepartmentName = "IT" }
                ,new Department{ Id = 2,DepartmentName = "MARKETING" }
                ,new Department{ Id = 3,DepartmentName = "HR" }
            };

         }
        public static List<EmployeeJoin> SampleEmployeeJoin()
        {
            return new List<EmployeeJoin>
            {
                    new EmployeeJoin{EmpName = "Om",EmployeeID = 1, EmpSalary = 50000 ,DepID = 1}
                    ,new EmployeeJoin{EmpName = "Aayush",EmployeeID = 2, EmpSalary = 40000 ,DepID =2 }
                    ,new EmployeeJoin{EmpName = "Vishw",EmployeeID = 3, EmpSalary = 60000 ,DepID = 3}
                    ,new EmployeeJoin{EmpName = "Niken",EmployeeID = 4, EmpSalary = 30000 ,DepID =1 }

            };
        }
    }
}

