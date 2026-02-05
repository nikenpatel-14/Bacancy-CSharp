using System;
using System.Collections.Generic;
using System.Text;
using LINQDay3Assignment.Models;

namespace LINQDay3Assignment.SampleData
{
    internal class SampleData
    {
        public static List<Employee> SampleEmpData()
        {
            return new List<Employee> {
                        new Employee{EmpName = "Mann",EmployeeID = 1, EmpSalary = 50000 , Department = "IT"}
                        ,new Employee{EmpName = "Aayush",EmployeeID = 2, EmpSalary = 40000 , Department = "HR"}
                        ,new Employee{EmpName = "Om",EmployeeID = 3, EmpSalary = 60000 , Department = "HR"}
                        ,new Employee{EmpName = "Smit",EmployeeID = 4, EmpSalary = 25000 , Department = "IT"}
                        ,new Employee{EmpName = "Vishw",EmployeeID = 5, EmpSalary = 15000 , Department = "HR"}
                        ,new Employee{EmpName = "Niken",EmployeeID = 6, EmpSalary = 90000 , Department = "IT"}
            };
        }
        public static List<Student> SampleStudentData()
        {
            return new List<Student>{
                    new Student{ RollNo = 1 , StuName = "NIKEN" , Marks = 80}
                    , new Student { RollNo = 2 , StuName = "MANN" , Marks = 35}
                    , new Student { RollNo = 3 , StuName = "SMIT" , Marks = 45}
                };

        }
        public static List<Order> SampleOrderData()
        {
            return new List<Order>{
         
            new Order {OrderId = 1,  CustomerName = "Niken", OrderItems = new List<OrderItem>
                          {
                              new OrderItem { ProductName = "Laptop", Price = 55000 }
                             ,new OrderItem { ProductName = "Mouse", Price = 500 }
                          }
                      }
            ,new Order{ OrderId = 2,CustomerName = "Mann", OrderItems = new List<OrderItem>
                          {
                              new OrderItem { ProductName = "Mobile", Price = 30000 }
                             ,new OrderItem { ProductName = "Headphones", Price = 2000 }
                             ,new OrderItem { ProductName = "Charger", Price = 1200 }
                          }
                      }
            };
        }
        public static List<EmployeeJoin> SampleEmpFORJoin()
        {
            return new List<EmployeeJoin>
            {
                    new EmployeeJoin{EmpName = "Om",EmployeeID = 1, EmpSalary = 50000 ,DepID = 1}
                    ,new EmployeeJoin{EmpName = "Aayush",EmployeeID = 2, EmpSalary = 40000 ,DepID =2 }
                    ,new EmployeeJoin{EmpName = "Vishw",EmployeeID = 3, EmpSalary = 60000 ,DepID = 3}
                    ,new EmployeeJoin{EmpName = "Niken",EmployeeID = 4, EmpSalary = 30000 ,DepID =1 }

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


        public static List<Product> SampleProductdata()
        {
            return new List<Product> {
                              new Product { ProductName = "Mobile", Id = 1 }
                             ,new Product { ProductName = "Headphones", Id = 2 }
                              ,new Product { ProductName = "Mobile", Id = 1}
                             ,new Product { ProductName = "Headphones", Id = 2 }
                             ,new Product { ProductName = "Charger", Id = 5 }
            };

        }
    }
}
