using EFCoreDemo.Data;
using EFCoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo
{
    internal class CRUDMethods
    {
        public void AddStudent(EFCoreDbContext dbContext)
        {
            Console.WriteLine("Enter student name");
            Student student = new Student();
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter student email");
            student.Email = Console.ReadLine();
            student.CreatedDate = DateTime.Now;

            dbContext.Students.Add(student);
            dbContext.SaveChanges();
            
        }
        public void showAllStudent(EFCoreDbContext dbContext) 
        {
            Console.WriteLine("All students data");
            var students = dbContext.Students.Select(x => new { x.StudentId, x.Name, x.Email, x.CreatedDate });
            foreach (var stu in students)
            {
                Console.WriteLine($"Student Id = {stu.StudentId},Student Name = {stu.Name} ,Student Email = {stu.Email},CreateTimeStamp = {stu.CreatedDate}");
            }   
        }
        public void AddCourse(EFCoreDbContext dbContext)
        {
            Course course = new Course();
            Console.WriteLine("Enter the course title");
            course.Title = Console.ReadLine();
            Console.WriteLine("Enter the course price");
            course.Price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Duration in Months");
            course.DurationInMonths = Convert.ToInt32(Console.ReadLine());
            dbContext.Courses.Add(course);
            dbContext.SaveChanges();

        }
        public void showAllCourse(EFCoreDbContext dbContext)
        {
            Console.WriteLine("All Courses data");
            var courses = dbContext.Courses.Select(x => new { x.CourseId, x.Title, x.Price, x.DurationInMonths });
            foreach (var c in courses)
            {
                Console.WriteLine($"Course Id = {c.CourseId},Course Title = {c.Title},Course Price = {c.Price} , DurationInMonths = {c.DurationInMonths}");
            }

        }

    }
}
