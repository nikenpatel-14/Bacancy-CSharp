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
            default:
                Console.WriteLine("enter the valid input");
                break;
        }
    }while (true);

}


