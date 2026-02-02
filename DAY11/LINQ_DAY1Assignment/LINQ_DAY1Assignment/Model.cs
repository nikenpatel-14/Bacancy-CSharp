using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ_DAY1Assignment
{

    //Model classes

    //Employee Model
    class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int EmpSalary { get; set; }

        public string Department { get; set; }

        public string City { get; set; }
    }
    //Student Model
    class Student
    {
        public int RollNo { get; set; }
        public string StuName { get; set; }
        public int Marks { get; set; }
    }


     class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }

    class OrderItem
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
    }

}
