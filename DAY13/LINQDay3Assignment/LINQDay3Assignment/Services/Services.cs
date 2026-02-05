using LINQDay3Assignment.Models;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace LINQDay3Assignment.Services
{
    internal class Services
    {


        public  static void AssignmentTask1()
        {
            //sample data
            List<Employee> employees = SampleData.SampleData.SampleEmpData();
            var Emp = employees.Where(x => x.EmpSalary > 30000);
            employees.Add(new Employee { EmpName = "Raj", EmployeeID = 7, EmpSalary = 50000, Department = "HR" });

            //obeserved deffered execution
            //because in linq there is not as such method which force it execution
            //so if we try to modify the source abd it has value which satisfy the condtion it reflect in result
            //in this case new data of raj will be printed
            //it execute at the time of foreach execution

            foreach (var emp in Emp)
            {
                Console.WriteLine($"Employee Id : {emp.EmployeeID} , Employee Name : {emp.EmpName} , Employee Salary : {emp.EmpSalary} , Department name : {emp.Department}");
            }
        }
        public static void AssignmentTask2() 
        {
            //sample data
            List<Student> students = SampleData.SampleData.SampleStudentData();

            var stu = students.Where(x => x.Marks > 40).ToList();

            //deffered execution
            //in thhis case  querry is just defined on source does not execute
            //it execute when it actually needed
            //so if we try to modify source with scondition satisfying data then it will printedin result

            //immediate execution
            //in this case querry is forced for execution
            //by using tolist,toarray,count,first etc.
            //so by that querry will execute
            //after that if we modify it does not reflect in result
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
            //sample data
            List<Order> orders = SampleData.SampleData.SampleOrderData();

            //immediate execution type
            //In this case first we use to lsit which iterate through source to create list which force execution of the linq
            //same goes in the case of count where count iterates through ienumrable to calculate total counts
            //using select many in this case to flatten list like order->id,cusnamme,(orderitems->product name,price)
            //so it flattens that list inside list and then we can select product name 
            //tolist will force execution so  by output we get list of product name
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
            //sample data
            List<Employee> employees = SampleData.SampleData.SampleEmpData();

            //linq method :groupby,key,select with annonymus type and count
            //groupby : int his case i used groupby to do grouping of the source based on the department
            //key : it returns the valued based on groupby perfromed
            //select : it used to do projection of the feild in this case depname and total count by using annonymus type
            //count : oit used to calculate the totalcount opf employee in each department
            //it works on deffered execution at first querry is just defined 
            //then when loop execute it force eaxecution of querry at actual needed time
            var Emp = employees.GroupBy(x => x.Department).Select(x => new { DepartmentName =x.Key, Totalcount = x.Count() });
            foreach(var emp in Emp)
            {
                Console.WriteLine($"DepartmentName : {emp.DepartmentName} , Count of Employee : {emp.Totalcount}");
            }
        }
        public static void AssignmentTask6()
        {
            List<EmployeeJoin> employeeJoins = SampleData.SampleData.SampleEmpFORJoin();
            List<Department> departments = SampleData.SampleData.SampleDepData();


            //Bad Way(N+1) problem
            //N+1 Means if we fetch result directly without using join 
            //and then fecth second result by iteerating n times
            //so second querry will execute for n times
            //in this case at first we get emp list and then inside for each loop we check dep id == emp dep id for every employee
            //so if n employee then it execute n times
            //this called n+1 problem to resolve it i use join in second way
            //N times execution create overhead 
            Console.WriteLine("WITH N+1 PEOBLEM");
            var Emp = employeeJoins.ToList();//It execcute one time
            foreach(var emp in Emp)
            {
                var dep = departments.First(x => x.Id == emp.DepID);//it execute N times
                Console.WriteLine($"Employee name : {emp.EmpName} , Department Name : {dep.DepartmentName}");
            }

            Console.WriteLine("BY WRITING SINGLE QUERRY");
            var Empdata = employeeJoins.Join(departments, x => x.DepID, d => d.Id, (x, d) => new {x.EmpName ,d.DepartmentName});//it just execute once
            foreach(var emp in Empdata)
            {
                Console.WriteLine($"Employee name : {emp.EmpName} , Department Name : {emp.DepartmentName}");
            }
        }
        public static void AssignmentTask7()
        {
            //sample data
            List<Product> products = SampleData.SampleData.SampleProductdata();

            //count before removing duplicates
            var CountBef = products.Count();
            //using distinctby
            //distinct by give the unique result of the source
            //in distinct by we provide arrowfucntion to distinct by product name
            //so this will give outpu of only unique product name
            var productUnique = products.DistinctBy(x => x.ProductName);
            //count after removing duplicates
            var CountAft = productUnique.Count();

            Console.WriteLine("count before : " +CountBef);
            foreach(var pro in productUnique)
            {
                Console.WriteLine("All unique Product name " +pro.ProductName);
            }
            Console.WriteLine("count after : "+CountAft);

        }
        public static void AssignmentTask8()
        {
            //SAMPLE DATA
            List<Employee> employees = SampleData.SampleData.SampleEmpData();

            // LINQ FEATURE : ToDictionary()
            //ToDictionary() is an immediate execution it iterates to entire source in this case it was employees
            //to fetch key and value pair
            //so it force to linq for immediate execution

            var Dict = employees.ToDictionary(e => e.EmployeeID, e => e.EmpName);
            foreach(var D in Dict)
            {
                Console.WriteLine($"EMployeee ID : {D.Key} , Employee Name : {D.Value}");
            }
        }
        public static void AssignmentTask9()
        {
            //SAMPLE DATA
            List<Employee> employees = SampleData.SampleData.SampleEmpData();

            //LINQ FEATURE : WHERE
            //USING WHERE TO FETCH EMPLOYEE OF DEPARTMENT IT
            var ItEmp = employees.Where(x => x.Department == "IT");
            //THIS PRINTS ALL THE EMPLOYEE IN IT DEPARTMENT
            //APPLING LOOP WILL EXECUTE THE QUERRY (DEFFERED EXECUTION)
            foreach(var emp in ItEmp)
            {
                Console.WriteLine($"Employee Id : {emp.EmployeeID} , Employee Name : {emp.EmpName} , Employee Salary : {emp.EmpSalary} , Department name : {emp.Department}");

            }


            //CHANGING DEPARTMENT OF EMPLOYEE AT INDEX 0 INT HIS CASE IT->HR
            employees[0].Department  = "HR";
            //THIS CHANGE APPLIES IN EMPLOYEES LIST SO AFTER THAT IT REMOVES ONE EMPLOYEE FROM IT SO IT DOES NOT PRINT MANN
            //ITEMP IENUMRABLE ONLY HAS DATA WHICH SATISFY THE CONDITION
            foreach (var emp in ItEmp)
            {
                Console.WriteLine($"Employee Id : {emp.EmployeeID} , Employee Name : {emp.EmpName} , Employee Salary : {emp.EmpSalary} , Department name : {emp.Department}");

            }

        }

    }
}
