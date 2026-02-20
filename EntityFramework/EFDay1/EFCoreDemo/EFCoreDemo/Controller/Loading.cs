using EFCoreDemo.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Controller
{
    internal class Loading
    {
        public void EagerLoadingExample(EFCoreDbContext dbContext)
        {

            Console.WriteLine("Enter Student ID");
            int sid = int.Parse(Console.ReadLine());
            var result = dbContext.Students.Include(x => x.Courses).ThenInclude(a => a.batches).FirstOrDefault(x=>x.StudentId == sid);
        
            Console.WriteLine($"student name ={result.Name} , courses count = {result.Courses.Count()}");
 
  

        }
        public void ExplicitLoadingExample(EFCoreDbContext dbContext)
        {
            var students = dbContext.Students.FirstOrDefault(x=>x.StudentId == 1);

            dbContext.Entry(students).Collection(x => x.Courses).Load();

            Console.WriteLine("Student Name"+students.Name);
            Console.WriteLine("courses");

            foreach(var c in students.Courses)
            {
                Console.WriteLine(c.Title);
            }
        }

        public void NplusOneVsInclude(EFCoreDbContext dbContext)
        {
            int countNplusOne= 0;
            var result = dbContext.Batchs.ToList();
            countNplusOne++;
            foreach (var item in result)
            {
                var courses = item.Course;
                countNplusOne++;
                Console.WriteLine(item.Id);
                
            }
            Console.WriteLine("total query executed without include " + countNplusOne);
            int countInclude = 0;
            var result2 = dbContext.Batchs.Include(x => x.Course);
            countInclude++;
            foreach (var item in result2)
            {
                Console.WriteLine(item.Course.Title);

            }

            Console.WriteLine("total query executed with include " + countInclude);

        }
        public void LazyLoading(EFCoreDbContext dbContext)
        {
            var students = dbContext.Students.ToList();

            foreach (var student in students)
            {
                foreach (var c in student.Courses)
                {
                    Console.WriteLine(c.Title);
                }
            }
        }

        public void DetachedDemo(EFCoreDbContext dbContext)
        {
            var result = dbContext.Students.Find(1);
            Console.WriteLine("Name befor update" +result.Name);
            Console.WriteLine("state "+dbContext.Entry(result).State);
            dbContext.Entry(result).State = EntityState.Detached;
            result.Name = "NikenPatel";
            dbContext.SaveChanges();
            Console.WriteLine("state "+dbContext.Entry(result).State);
            var result2 = dbContext.Students.Find(1);
            Console.WriteLine("Name after update"+result2.Name);
        }
        public void asNoTrackingAttach(EFCoreDbContext dbContext)
        {
            var student = dbContext.Students.AsNoTracking().FirstOrDefault();
            Console.WriteLine("student name" + student.Name);
            Console.WriteLine("Enter updated name");
            student.Name = Console.ReadLine();

            dbContext.Attach(student);
            dbContext.SaveChanges();
            var student2 = dbContext.Students.FirstOrDefault();
            Console.WriteLine("student updated name" + student2.Name);

        }
    }
}
