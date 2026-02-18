// See https://aka.ms/new-console-template for more information
using EFCoreDemo;
using EFCoreDemo.Data;
using EFCoreDemo.Model;


using (EFCoreDbContext dbContext = new EFCoreDbContext())
{

    CRUDMethods Crud = new CRUDMethods();

    do
    {
        Console.WriteLine("******ConsoleMenu******");
        Console.WriteLine(" 1) Add Student");
        Console.WriteLine(" 2) Add Course");
        Console.WriteLine(" 3) Show All Students");
        Console.WriteLine(" 4) Show All Courses");
        Console.WriteLine(" 5) Enroll Student in Course");
        Console.WriteLine(" 6) Create Batch");
        Console.WriteLine(" 7) Show Course with Students");
        Console.WriteLine(" 8) Show Trainer with Batches");
        Console.WriteLine(" 9) EXIT");
        Console.WriteLine("\nENTER YOUR OPTION\n");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                Crud.AddStudent(dbContext);
                break;
            case 2:
                Crud.AddCourse(dbContext);
                break;
            case 3:
                Crud.showAllStudent(dbContext);
                break;
            case 4:
                Crud.showAllCourse(dbContext);
                break;
            case 5:
                Crud.EnrollStuInCourse(dbContext);
                break;
            case 6:
                Crud.createBatch(dbContext);
                break;
            case 7:
                Crud.showCourseWithStudent(dbContext);
                break;
            case 8:
                Crud.showTrainerWithBatches(dbContext);
                break;
            case 9:
                break;
            default:
                Console.WriteLine("Enter The Valid Input\n");
                break;
        }
        if(option == 9)
        {
            break;
        }
    } while (true);



}


