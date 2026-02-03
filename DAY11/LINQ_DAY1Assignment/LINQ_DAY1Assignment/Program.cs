
using LINQ_DAY1Assignment;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        //sample data


        #region [SAMPLE DATA]
        List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeId = 1, EmpSalary = 50000, Name = "Niken" , Department = "IT" , City ="Mehsana"}
            , new Employee { EmployeeId = 2, EmpSalary = 65000, Name = "Mann" , Department = "IT" , City = " Surendranagar"}
            , new Employee { EmployeeId = 3, EmpSalary = 40000, Name = "om" , Department = "MARKETING" , City = "Anand"}
            , new Employee {EmployeeId = 4 , EmpSalary = 15000, Name = "vishw", Department = "IT" , City = "Ahmedabad"}
        };

        List<Student> students = new List<Student>
        {
            new Student{ RollNo = 1 , StuName = "NIKEN" , Marks = 80}
            , new Student { RollNo = 2 , StuName = "MANN" , Marks = 35}
            , new Student { RollNo = 3 , StuName = "SMIT" , Marks = 45}
        };

        List<Order> orders = new List<Order>
        {
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
        #endregion

        //TASK runner methods
        #region[TASK RUN METHODS]
        //RunTask1(employees);
        //RunTask2(employees);
        //RunTask3(employees);
        //RunTask4(employees);
        //RunTask5(students);
        //RunTask6(employees);
        //RunTask7(orders);
        //RunTask8(orders);
        //string[] storeEmpName = RunTask9(employees);
        // RunTask10(employees);
        #endregion

    }

    #region[Task 1]
    static void RunTask1(List<Employee> employees)
    {
        Console.WriteLine("SALARY GRETER THEN 25000");
        var HighSalEmp = employees.Where(n => n.EmpSalary > 25000).ToList();
        foreach (var emp in HighSalEmp)
        {
            Console.WriteLine($"Employee ID = {emp.EmployeeId}  , Employee name = {emp.Name}  , Employee Salary = {emp.EmpSalary}");
        }
    }
    //LINQ FEATURE USED : WHERE,TOLIST
    //USING Where as an clause to apply condition it applies selection
    //by using Tolist linq execute and also it convert the result in list

    #endregion

    #region[Task 2]
    static void RunTask2(List<Employee> employees)
    {
        Console.WriteLine("IT DEPARTMENT EMPLOYEE");
        var ITEmp = employees.Where(n => n.Department == "IT").Select(n => new { n.Name, n.EmpSalary });
        foreach (var emp in ITEmp)
        {
            Console.WriteLine($"Employee Name = {emp.Name} , Employee Salary = {emp.EmpSalary}");
        }
    }
    //Linq feature used : where,select
    //using where to apply  condition selection deaprtment == it
    //applying select to apply projectioj of name and salary by annonymus type
    #endregion

    #region[Task 3]
    static void RunTask3(List<Employee> employees)
    {
        Console.WriteLine("GREATER THEN 30000 SALARY AND ORDERBY SALARY");
        var SortedSalEmp = employees.Select(n => new { n.EmployeeId, n.Name, n.EmpSalary }).Where(n => n.EmpSalary > 30000).OrderBy(n => n.EmpSalary).ToList();
        foreach (var emp in SortedSalEmp)
        {
            Console.WriteLine($"Employee ID = {emp.EmployeeId},Employee Name = {emp.Name} , Employee Salary = {emp.EmpSalary}");
        }
    }
    //linq feature used  select,where,orderby
    //select is used to select id,name and salary
    //where is used to apply condition of empsalary > 30000
    //order by is used to make asscending order based on salary
    #endregion

    #region[Task 4]
    static void RunTask4(List<Employee> employees)
    {
        Console.WriteLine("ORDER BY DEPARTMENT THEN NAME ");
        var MultilevelSorted = employees.OrderBy(n => n.Department)
                               .ThenBy(n => n.Name)
                               .Select(n => new { n.EmployeeId, n.Name, n.Department });

        foreach (var emp in MultilevelSorted)
        {
            Console.WriteLine($"Employee ID = {emp.EmployeeId},Employee Name = {emp.Name} , Employee Department = {emp.Department}");
        }


    } 
    //linq feature used : orderby,thenby,select
    //orderby : to order based on department it makes it in asscending order
    //thenby : it used to mske multilevel ordering where thenby make order based on name
    //select : it select the feild id,name,department
    #endregion

    #region[Task 5]

    static void RunTask5(List<Student> students)
    {
        
        Console.WriteLine("student name and marks by adding feild result show pass or fail");
        var StudentPassFail = students.Select(n => new { n.StuName, n.Marks, Result = n.Marks > 40 ? "PASS" : "FAIL" }).ToList();
        foreach (var s in StudentPassFail)
        {
            Console.WriteLine($"Student Name = {s.StuName} , Student Marks = {s.Marks} , Student Result = {s.Result}");
        }
    }
    //Linq feature : select,annonymus type,declaring resukt by ternary
    //select : it select name ,marks
    //annonymus type : it create a new object of type which has feild name,marks and result
    //result using ternary,add new feild result by using ternary if marks >40 then pass else fail

    #endregion

    #region[Task 6]

    static void RunTask6(List<Employee> employees)
    {
        var AnnonymusCity = employees.Select(n => new { n.Name, n.Department, n.City }).ToList();
        foreach (var emp in AnnonymusCity)
        {
            Console.WriteLine($"Employee name : {emp.Name} , Employee department : {emp.Department} , employee city : {emp.City}");
        }

    }
    //Linq feature used : SELECT,ANNONYMUS TYPE
    //SELECT MAKE THE SELECTION OF FEILD
    //BY USING ANNONYMUS TYPE WE CAN DECLARE THE NEW OBJECT WHOICH HAS TYPE NAME ,DEPARTMENT AND CITY
    //ANNONYMUS TYPE USECASE ; there's no prior requirement to declare a object for result

    #endregion

    #region[Task 7]
    static void RunTask7(List<Order> orders)
    {
        var FlattenOrderItems = orders.SelectMany(n => n.OrderItems).Select(o => o.ProductName);
        foreach(var items in FlattenOrderItems)
        {
            Console.WriteLine($"Product NaME : {items}");
        }
    }// Linq feature used  selectmany and select
    //select many : it used to flatten one to many relationship in this case order items
    //select : it select productname for orderitems


    #endregion

    #region[Task 8]
    static void RunTask8(List<Order> orders)
    {
        var CusNameProductName = orders.SelectMany(o => o.OrderItems, (o, i) => new { o.CustomerName, i.ProductName });

        foreach (var items in CusNameProductName)
        {
            Console.WriteLine($"Customer Name : {items.CustomerName} , Product Name : {items.ProductName} ");
        }
    }
    //linq featuire used : selectmany  and selected cus name and product namew
    
    #endregion

    #region[Task 9]
    static string[] RunTask9(List<Employee> employees)
    {
        return employees.Select(n => n.Name).ToArray();

    }

    #endregion

    #region[Task 10]

    static void RunTask10(List<Employee> employees)
    {
        //query syntax
        var result1 = from emp in employees
                      where emp.EmpSalary <= 50000
                      orderby emp.City
                      select new { emp.Name, emp.City };

        foreach(var emp in result1)
        {
            Console.WriteLine($"employee name : {emp.Name} , employee city : {emp.City}");
        }


        //method syntax
        var result2 = employees.Where(n => n.EmpSalary <= 50000).OrderBy(n => n.City).Select(n => new { n.Name, n.City });

        foreach (var emp in result2)
        {
            Console.WriteLine($"employee name : {emp.Name} , employee city : {emp.City}");
        }
    }
    #endregion


}
