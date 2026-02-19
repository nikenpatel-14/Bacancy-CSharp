using EFCoreDemo.Data;
using EFCoreDemo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Controller
{
    internal class CourseCRUD
    {

        public void Run(EFCoreDbContext context)
        {
            Console.WriteLine("***CRUDOperation***");
            Console.WriteLine("1)Add Course\n2)Get Course\n3)Update Course\n4)Delete Course");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addCourse(context);
                    break;
                case 2:
                    getCourse(context);
                    break;
                case 3:
                    updateCourse(context);
                    break;
                case 4:
                    deleteCourse(context);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
        public void addCourse(EFCoreDbContext dbContext)
        {
            Course course = new Course();
            Console.WriteLine("Enter the course title");
            course.Title = Console.ReadLine();
            Console.WriteLine("Enter the course price");
            course.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Duration in Months");
            course.DurationInMonths = Convert.ToInt32(Console.ReadLine());
            dbContext.Courses.Add(course);
            Console.WriteLine("STAT BEFORE SAVECHANGES " + dbContext.Entry(course).State);
            dbContext.SaveChanges();
            Console.WriteLine("STAT AFTER SAVECHANGES " + dbContext.Entry(course).State);

        }
        public void getCourse(EFCoreDbContext dbContext)
        {
            Console.WriteLine("Enter Course ID");
            var cid = int.Parse(Console.ReadLine());
            var result = dbContext.Courses.FirstOrDefault(x=>x.CourseId == cid);
            if(result == null)
            {
                Console.WriteLine("course does not exist");
            }
            else
            {
                Console.WriteLine($"Course Title ={result.Title},Course Price = {result.Price} ,DurationInMonths ={result.DurationInMonths}");
            }
            
        }
        public void updateCourse(EFCoreDbContext dbContext)
        {

            Console.WriteLine("Enter Course ID");
            var cid = int.Parse(Console.ReadLine());
            var result = dbContext.Courses.FirstOrDefault(x => x.CourseId == cid);
            if (result == null)
            {
                Console.WriteLine("course does not exist");
            }
            else
            {
                Console.WriteLine("what you want to modify");
                Console.WriteLine("1)Course Title\n2)Course Price\n 3)Course Duration 4)All three ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Course Title");
                        result.Title = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter Course PRICE");
                        result.Price = int.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter Course Duration In Months");
                        result.DurationInMonths = int.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Enter Course Title");
                        result.Title = Console.ReadLine();
                        Console.WriteLine("Enter Course PRICE");
                        result.Price = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Course Duration In Months");
                        result.DurationInMonths = int.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Enter the valid input");
                        break;
                }
                Console.WriteLine("STAT BEFORE SAVECHANGES " + dbContext.Entry(result).State);
                dbContext.SaveChanges();
                Console.WriteLine("STAT AFTER SAVECHANGES " + dbContext.Entry(result).State);
            }
        }
        public void deleteCourse(EFCoreDbContext dbContext)
        {

            Console.WriteLine("Enter Course ID");
            var cid = int.Parse(Console.ReadLine());
            var result = dbContext.Courses.FirstOrDefault(x => x.CourseId == cid);
            if (result == null)
            {
                Console.WriteLine("course does not exist");
            }
            else
            {
                dbContext.Courses.Remove(result);
                Console.WriteLine("STAT BEFORE SAVECHANGES " + dbContext.Entry(result).State);
                dbContext.SaveChanges();
                Console.WriteLine("STAT AFTER SAVECHANGES " + dbContext.Entry(result).State);
            }


        }

    }
}
