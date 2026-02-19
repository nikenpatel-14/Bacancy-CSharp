using EFCoreDemo.Data;
using EFCoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Controller
{
    internal class StudentCRUD
    {
        public void Run(EFCoreDbContext context)
        {
            Console.WriteLine("***CRUDOperation***");
            Console.WriteLine("1)Add Student\n2)Get Student \n3)Update Student\n4)Delete Student");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addStudent(context);
                    break;
                case 2:
                    getStudent(context);
                    break;
                case 3:
                    updateStudent(context);
                    break;
                case 4:
                    deleteStudent(context);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
        public void addStudent(EFCoreDbContext dbContext)
        {

            Console.WriteLine("Enter student name");
            Student student = new Student();
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter student email");
            student.Email = Console.ReadLine();
            student.CreatedDate = DateTime.Now;
            dbContext.Students.Add(student);
            Console.WriteLine("STAT BEFORE SAVECHANGES " + dbContext.Entry(student).State);
            dbContext.SaveChanges();
            Console.WriteLine("STAT AFTER SAVECHANGES " + dbContext.Entry(student).State);

        }
        public void getStudent(EFCoreDbContext dbContext)
        {
            Console.WriteLine("Enter Student ID");
            int sid = int.Parse(Console.ReadLine());
            var result = dbContext.Students.FirstOrDefault(x=>x.StudentId == sid);
            if(result == null)
            {
                Console.WriteLine("student does not exist");
            }
            else
            {
                Console.WriteLine($"Student Name = {result.Name}, Student Email = {result.Email}, Created Date = {result.CreatedDate}");

            }

        }
        public void updateStudent(EFCoreDbContext dbContext)
        {
            Console.WriteLine("Enter Student ID");
            int sid = int.Parse(Console.ReadLine());
            var result = dbContext.Students.FirstOrDefault(x => x.StudentId == sid);
            if (result == null)
            {
                Console.WriteLine("student does not exist");
            }
            else
            {
                Console.WriteLine("what you want to modify");
                Console.WriteLine("1)Student Name\n2)Student Email\n 3)Both ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Student Name");
                        result.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter Student Email");
                        result.Email = Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter Student Name");
                        result.Name = Console.ReadLine();
                        Console.WriteLine("Enter Student Email");
                        result.Email = Console.ReadLine();
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
        public void deleteStudent(EFCoreDbContext dbContext) 
        {
            Console.WriteLine("Enter Student ID");
            int sid = int.Parse(Console.ReadLine());
            var result = dbContext.Students.FirstOrDefault(x => x.StudentId == sid);
            if (result == null)
            {
                Console.WriteLine("student does not exist");
            }
            else
            {
                dbContext.Students.Remove(result);
                Console.WriteLine("STAT BEFORE SAVECHANGES " + dbContext.Entry(result).State);
                dbContext.SaveChanges();
                Console.WriteLine("STAT AFTER SAVECHANGES " + dbContext.Entry(result).State);
            }

        }
    }
}
