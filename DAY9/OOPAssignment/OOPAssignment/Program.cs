// See https://aka.ms/new-console-template for more information


class Program 
{

    static void Main(string[] args)
    {
        ////Assignment 1
        //FullTimeEmployee e1= new FullTimeEmployee();
        //e1.calculateSalary(10);
        //ContractEmployee e2 = new ContractEmployee();
        //e2.calculateSalary(10);
        ////base reference to call overridden method
        //Employee e3 = new FullTimeEmployee();
        //e3.calculateSalary(10);


        //Assignment 2
        //DerivedClass derivedClass = new DerivedClass("Log");
        //DerivedClass derivedClass1 = new DerivedClass(5, 10);


        ////Assignment 3
        ////overloading
        //PaymentProcessor payment = new PaymentProcessor();
        //payment.processPayment(10);
        //payment.processPayment(10,20);
        //payment.processPayment(2.7);
        ////overridding
        //CreditCard creditCard = new CreditCard();
        //Upi upi = new Upi();
        //creditCard.paymentBehaviour();
        //upi.paymentBehaviour();


        ////Assignment 4
        //PDFReport pDFReport = new PDFReport();
        //ExcelReport excelReport = new ExcelReport();
        //pDFReport.generateReport();
        //excelReport.generateReport();


        //Assignment 5

        child child = new child();
        Parant parant = new child();
        //in both case it called overridden method
        child.showMsg();
        parant.showMsg();

        //In parant class referenc it called parant  method
        child.newMethod();
        parant.newMethod();
    }
    
}



#region [Assignment-1:Employee Hierarchy]
class Employee 
{

    public double salary;
    public virtual void calculateSalary(double hours)
    {
        salary = hours * 2000;
        Console.WriteLine("salary of employess : "+salary);
    }
}
class FullTimeEmployee : Employee
{
    
    public override void calculateSalary(double hours)
    {
        salary = hours * 2200;
        Console.WriteLine("salary of fulltime employee : "+salary);
    }
}
class ContractEmployee : Employee
{
    public override void calculateSalary(double hours)
    {
        salary = hours * 1500;
        Console.WriteLine("salary of contraqct employee : "+salary);
    }
}

#endregion

#region [Assignment-2:Base Keyword Exploration]

class BaseClass
{
    public BaseClass()
    {
        Console.WriteLine("base class default ctor");
    }
    public BaseClass(string msg)
    {
        Console.WriteLine("Base class ctor parameterized : " +msg);
    }
    public BaseClass(int a,int b)
    {
        a += 5;
        b += 5;
        Console.WriteLine($"new value of a : {a} ,b : {b}");
    }
}
class DerivedClass : BaseClass
{
    public DerivedClass(string msg) : base(msg) // if we do not use base keyword it called default ctor of baseclass
    {
        
        Console.WriteLine("derived class ctor : "+msg);
    }
    public DerivedClass(int a, int b) : base(a, b){ }
}
#endregion

#region [Assignment-3:Payment Processor]

class PaymentProcessor 
{
    public void processPayment(int a)
    {
        Console.WriteLine($"method overloading passed param  A : {a} ");
    }
    public void processPayment(int a , int b)
    {
        Console.WriteLine($"method overloading passed param A : {a} , B : {b}");

    }
    public void processPayment(double a)
    {
        Console.WriteLine($"method overloading param passed A : {a}");
    }

    public virtual void paymentBehaviour()
    {
        Console.WriteLine("payment behaviour base method");
    }
}
class CreditCard : PaymentProcessor
{
    public override void paymentBehaviour()
    {
        Console.WriteLine("creditcard payment behaviour overidden method");
    }
}
class Upi : PaymentProcessor 
{
    public override void paymentBehaviour()
    {
        Console.WriteLine("upi payment behaviour overridden method");
    }
}


#endregion

#region [Assignment-4:Abstract Report Generator]
abstract class ReportGenerator 
{
    public abstract void generateReport();
}
class PDFReport : ReportGenerator
{
    public override void generateReport()
    {
        Console.WriteLine("PDF report genereted");
    }
}
class ExcelReport : ReportGenerator 
{
    public override void generateReport()
    {
        Console.WriteLine("EXCEL report genereted");
    }
}


#endregion

#region [Assignment-5:Method Hiding Trap]

class Parant
{
    public virtual void showMsg()
    {
        Console.WriteLine("parant class msg");
    }
    public void newMethod()
    {
        Console.WriteLine("new method example for parant");
    }
}
class child : Parant 
{

    public override void showMsg()
    {
        Console.WriteLine("OVERRIDDEN METHOD from child class");
    }
    public new void newMethod()
    {
        Console.WriteLine("new method example from child");
    }
}

#endregion