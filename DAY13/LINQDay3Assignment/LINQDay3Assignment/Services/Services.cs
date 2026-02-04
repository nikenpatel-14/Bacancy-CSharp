using LINQDay3Assignment.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDay3Assignment.Services
{
    internal class Services
    {


        public  static void AssignmentTask1()
        {

            List<Employee> employees = SampleData.SampleData.SampleEmpData();
            var Emp = employees.Where(x => x.EmpSalary > 30000);
            employees.Add(new Employee { EmpName = "Raj", EmployeeID = 7, EmpSalary = 50000, Department = "HR" });

            foreach (var emp in Emp)
            {
                Console.WriteLine($"Employee Id : {emp.EmployeeID} , Employee Name : {emp.EmpName} , Employee Salary : {emp.EmpSalary} , Department name : {emp.Department}");
            }
        }
        public static void AssignmentTask2() 
        {
            List<Student> students = SampleData.SampleData.SampleStudentData();
            var stu = students.Where(x => x.Marks > 40).ToList();

            students[1].Marks = 80;

            Console.WriteLine("RESULT OF THE QUERRY");
            foreach (var student in stu)
            {
                Console.WriteLine($"Student Name : {student.StuName} , Student RollNo : {student.RollNo} , Student Name : {student.Marks}");
            }
            Console.WriteLine("STUDETNS LIST PRINTED AFTER MODIFICATION");
            foreach (var student in students)
            {
                Console.WriteLine($"Student Name : {student.StuName} , Student RollNo : {student.RollNo} , Student Name : {student.Marks}");
            }

        }
        public static void AssignmentTask3()
        {
               List<Order> orders = SampleData.SampleData.SampleOrderData();
            var list = orders.SelectMany(x => x.OrderItems).Select(o => o.ProductName).ToList();
            int totalcount = orders.SelectMany(x => x.OrderItems).Count();

            foreach(var product in list)
            {
                Console.WriteLine("Product Name : "+product);
            }
            Console.WriteLine("Total Product count : " + totalcount);


        }
        public static void AssignmentTask4()
        {
            List<Employee> employees = SampleData.SampleData.SampleEmpData();
            var Emp = employees.GroupBy(x => x.Department).Select(x => new { DepartmentName =x.Key, Totalcount = x.Count() });
            foreach(var emp in Emp)
            {
                Console.WriteLine($"DepartmentName : {emp.DepartmentName} , Count of Employee : {emp.Totalcount}");
            }
        }
        public static void AssignmentTask7()
        {
            List<Product> products = SampleData.SampleData.SampleProductdata();

            var CountBef = products.Count();
            var productUnique = products.DistinctBy(x => x.ProductName);
            var CountAft = productUnique.Count();

            Console.WriteLine("count before : " +CountBef);
            foreach(var pro in productUnique)
            {
                Console.WriteLine("All unique Product name " +pro.ProductName);
            }
            Console.WriteLine("count after : "+CountAft);

        }


    }
}
