using EFCoreDemo.Data;
using EFCoreDemo.Migrations;
using EFCoreDemo.Model;
using Microsoft.EntityFrameworkCore;
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
        public void EnrollStuInCourse(EFCoreDbContext dbContext)
        {
            Console.WriteLine("Enter Course Title");
            string Cname = Console.ReadLine();
            Console.WriteLine("Enter student Name");
            string Sname = Console.ReadLine();


            var course = dbContext.Courses.FirstOrDefault(x => x.Title == Cname);
            var student = dbContext.Students.FirstOrDefault(x => x.Name == Sname);

            if (course != null) {
                student.Courses.Add(course);
                dbContext.SaveChanges();
            }
            else
            {
                Console.WriteLine("Course Does Not Exist");
            }

        }
        public void createBatch(EFCoreDbContext dbContext)
        {
            Console.WriteLine("Enter the Batch start date In format(YYYY-MM--DD)");
            Batch batch = new Batch();
            batch.StartDate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Course Title");
            string cname = Console.ReadLine();
            Console.WriteLine("Enter the Trainer Name");
            string tname = Console.ReadLine();

            var cobj = dbContext.Courses.FirstOrDefault(x => x.Title == cname);

            var tobj = dbContext.Trainers.FirstOrDefault(x => x.Name == tname);

            batch.TrainerId = tobj.Id;
            batch.CourseId = cobj.CourseId;

            dbContext.Batchs.Add(batch);
            dbContext.SaveChanges();

        }
        public void showCourseWithStudent(EFCoreDbContext dbContext)
        {
            var CoursesWithBatches = dbContext.Courses.SelectMany(x => x.Students, (c, x) => new {c.Title,c.CourseId,c.DurationInMonths,x.StudentId,x.Name});
            foreach(var obj in CoursesWithBatches)
            {
                Console.WriteLine($"Course Id = {obj.CourseId},Course Title = {obj.Title} , DurationInMonths = {obj.DurationInMonths},Student Name = {obj.Name} ,Student Id = {obj.StudentId}");
            }
        }
        public void showTrainerWithBatches(EFCoreDbContext dbContext)
        {
            var TrainersWithBatches = dbContext.Trainers.SelectMany(x => x.batches, (t, x) => new { t.Id, t.Name, t.ExperienceInYears, BatchId =x.Id, x.StartDate });


            foreach(var obj in TrainersWithBatches)
            {
                Console.WriteLine($"Trainer Id = {obj.Id},Trainer Name = {obj.Name},Experience = {obj.ExperienceInYears}, Bacth Id = {obj.Id} ,BatchStartDate = {obj.StartDate} ");
            }
        }
            

    }
}
