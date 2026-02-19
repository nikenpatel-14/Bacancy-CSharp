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
            var BatchCount = result.Courses.Select(x => new { batchcount = x.batches.Count() });
            Console.WriteLine($"student name ={result.Name} , courses count = {result.Courses.Count()} ,Batches Count ={BatchCount} ");
 
  

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
                var batches = result.Select(x => x.Course);
                countNplusOne++;
                foreach (var c in batches)
                {
                    Console.WriteLine(c.Title);
                }

            }

            int countInclude = 0;
            var result2 = dbContext.Batchs.Include(x => x.Course);
            countInclude++;
            foreach (var item in result)
            {


                

            }

        }
    }
}
