// See https://aka.ms/new-console-template for more information
using EFCoreDemo;
using EFCoreDemo.Controller;
using EFCoreDemo.Data;
using EFCoreDemo.Model;
using Microsoft.EntityFrameworkCore;


using (EFCoreDbContext dbContext = new EFCoreDbContext())
{

    CRUDMethods Crud = new CRUDMethods();

    Loading loading = new Loading();
  
    do
    {
        Console.WriteLine("\n******ConsoleMenu******");
        Console.WriteLine(" 1) Add Student");
        Console.WriteLine(" 2) Add Course");
        Console.WriteLine(" 3) Show All Students");
        Console.WriteLine(" 4) Show All Courses");
        Console.WriteLine(" 5) Enroll Student in Course");
        Console.WriteLine(" 6) Create Batch");
        Console.WriteLine(" 7) Show Course with Students");
        Console.WriteLine(" 8) Show Trainer with Batches");
        Console.WriteLine(" 9)Course Crud Operations");
        Console.WriteLine(" 10)Student Crud Operations");
        Console.WriteLine(" 11)Trainer Crud Operations");
        Console.WriteLine(" 12)Eager Loading example");
        Console.WriteLine(" 13)Explicit loading example");
        Console.WriteLine(" 14)N+1 VS USING INCLUDE");
        Console.WriteLine(" 15)DETACHED DEMO");
        Console.WriteLine(" 16)Lazy Loading example");
        Console.WriteLine(" 17) EXIT");
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
                CourseCRUD courseCRUD = new CourseCRUD();
                courseCRUD.Run(dbContext);
                break;
            case 10:
                StudentCRUD studentCRUD = new StudentCRUD();
                studentCRUD.Run(dbContext);
                break;
            case 11:
                TrainerCRUD trainerCRUD = new TrainerCRUD();
                trainerCRUD.Run(dbContext);
                break;
            case 12:
                loading.EagerLoadingExample(dbContext);
                break;
            case 13:
                loading.ExplicitLoadingExample(dbContext);
                break;
            case 14:
                loading.NplusOneVsInclude(dbContext);
                break;
            case 15:
                loading.DetachedDemo(dbContext);
                break;
            case 16:
                loading.LazyLoading(dbContext);
                break;
            case 17:
                break;
            default:
                Console.WriteLine("Enter The Valid Input\n");
                break;
        }
        if (option == 17)
        {
            break;
        }
    } while (true);


    //var t = dbContext.Trainers.Include(x => x.batches).ThenInclude(x=>x.Course).ThenInclude(x=>x.Students).ToList();
    //    foreach (var trainer in t)
    //{
    //    var batches = trainer.batches;
    //    Console.WriteLine($"{trainer.Name}, {trainer.batches}");
    //}
    //lazy loading
    //why navigation prop virtual


}
