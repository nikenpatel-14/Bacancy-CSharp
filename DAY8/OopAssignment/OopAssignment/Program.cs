// See https://aka.ms/new-console-template for more information


class Program
{
    static void Main(string[] args)
    {

        //Assignment 1
        //TempratureSensor sensor = new TempratureSensor();
        //sensor.Temp = 30;
        //sensor.Temp = 20;
        ////sensor.Temp = -300;
        //foreach (var item in sensor.TempHistory)
        //{
        //    Console.WriteLine("temprature is " + item);
        //}


        //Assignment 2
        //AppConfig app = new AppConfig("appName minor update","1.1.0",DateTime.Now);
        //it show error
        //app.AppVersion = "1.2.0";


        //Assignment 3
        //EmailNotification email = new EmailNotification();
        //email.notify();
        //email.showMsg("alert email");
        //email.emailNotifyStm();
        //SmsNotification sms = new SmsNotification();
        //sms.notify();
        //sms.showMsg("alert sms");
        //sms.smsNotifyStm();


        //Assignment 4
        //ILogging logging = new User();
       // User auditing = new User();
        //((ILogging)auditing).check();
        //logging.check();
        //auditing.check();



        //Assignment 5
        UserLogin user = new UserLogin();
        user.login();
        AdminAccess admin = new AdminAccess();
        admin.login();
        admin.adminAccess();
    }
}
#region [Assignment-1:Temprature_Monitor]
class TempratureSensor
{

    private const double AbsoluteZero = -273.15;
    private double temp;
    private List<double> tempHistory = new List<double>();


    public List<double> TempHistory { get { return tempHistory; } }

    public double Temp
    {
        get { return temp; }

        set
        {
            if (value < AbsoluteZero)
            {
                Console.WriteLine("temprature can not be below absolutezero");
            }
            else
            {
                temp = value;
                tempHistory.Add(temp);
            }
        }

    }
}
#endregion

#region [Assignment-2:AppConfig]

//by declaring sealed you can not inherit this class to access
sealed class AppConfig 
{ 
    public string AppName { get; private set; }
    public string AppVersion { get; private set; }
    public DateTime CreatedDate {  get; private set;}


    public AppConfig(string appname, string appversion, DateTime date)
    {
        AppName = appname;
        AppVersion = appversion;
        CreatedDate = date;

    }

}



#endregion

#region [Assignment-3:NotificationSystem]
interface INotification 
{
    void notify();
    void showMsg(string msg);
}
class EmailNotification : INotification 
{ 
    public void notify()
    {
        Console.WriteLine("notifcation for email");
    }
    public void showMsg(string msg) 
    {
        Console.WriteLine("message from email "+msg);
    }
    public void emailNotifyStm()
    {
        Console.WriteLine("this is email notification system");
    }
}

class SmsNotification : INotification
{
    public void notify()
    {
        Console.WriteLine("notifcation for sms");
    }
    public void showMsg(string msg)
    {
        Console.WriteLine("message from sms " + msg);
    }
    public void smsNotifyStm()
    {
        Console.WriteLine("this is sms notification system");
    }
}


#endregion

#region [Assignment-4:Explicit Interface Implementation]
interface ILogging
{
    void check();
}
interface IAuditing
{
    void check();
}
class User : ILogging, IAuditing 
{ 
   

    void IAuditing.check()
    {
        Console.WriteLine("Implement IAuditing interface");
    }
    void ILogging.check()
    {
        Console.WriteLine("Implement ILogging interface");
    }


}

#endregion

#region [Assignment-5:Interface Inheritance]
interface IUser 
{
    void login();

}
interface IAdminUser : IUser
{
   void adminAccess();
}


class UserLogin : IUser
{
     public void login()
    {
        Console.WriteLine("user logged in");
    }
}
class AdminAccess : IAdminUser
{
    public void login()
    {
        Console.WriteLine("admin logged in");
    }
    public void adminAccess()
    {
        Console.WriteLine("admin access provided");
    }
}


#endregion