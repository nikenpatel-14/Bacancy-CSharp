// See https://aka.ms/new-console-template for more information
using CorporateTrainingManagementSystem.ConsoleMenuServices;
using CorporateTrainingManagementSystem.Data;
using CorporateTrainingManagementSystem.Entity;



MenuServices ms = new MenuServices();

using(AppDbContext dbContext = new AppDbContext())
{
    do
    {
        Console.WriteLine("******consoleMenu******");
        Console.WriteLine("1.Create Training Program");
        Console.WriteLine("2.Register Employee");
        Console.WriteLine("3.Enroll Employee in Training");
        Console.WriteLine("4.Show Training Details(With Employees)");
        Console.WriteLine("5.Show Department Report");
        Console.WriteLine("6.Update Employee Performance");
        Console.WriteLine("7.Delete Training Program");
        Console.WriteLine("8.Exit");
        Console.WriteLine("Enter your option");
        int option = int.Parse(Console.ReadLine());

        switch (option)
        {
            case 1:
                ms.createTrainingProgram(dbContext);
                break;
            case 2:
                ms.RegisterEmployee(dbContext);
                break;
            case 3:
                ms.enrollEmployeeInTraining(dbContext);
                break;
            case 4:
                ms.showTrainingDetails(dbContext);
                break;
            case 5:
                ms.showDepartmentReport(dbContext);
                break;
            case 6:
                ms.updateEmpPerformance(dbContext);
                break;
            case 7:
                ms.deleteTrainingProgram(dbContext);
                break;
            case 8:
                break;
            default:
                Console.WriteLine("enter valid input");
                break;

        }
        if (option == 8)
        {
            break;
        }
    } while (true);




}