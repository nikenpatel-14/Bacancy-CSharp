using CorporateTrainingManagementSystem.Data;
using CorporateTrainingManagementSystem.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CorporateTrainingManagementSystem.ConsoleMenuServices
{
    internal class MenuServices
    {
        public void createTrainingProgram(AppDbContext dbContext)
        {
            Console.WriteLine("Enter Program Title");
            TrainingProgram trainingProgram = new TrainingProgram();
            string Title = Console.ReadLine();
            if(dbContext.TrainingPrograms.Any(x=>x.Title == Title))
            {
                Console.WriteLine("Program title already exist");
                return;
            }
            trainingProgram.Title = Title;
            Console.WriteLine("Enter Program Start Date in format(yyyy-mm-dd)");
            trainingProgram.StartDate = DateOnly.Parse(Console.ReadLine());
            Console.WriteLine("Enter Program Duration In Days");
            trainingProgram.DurationInDays = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainer ID");
            int tid = int.Parse(Console.ReadLine());
            var result = dbContext.Trainers.Any(x=>x.TrainerId == tid);
            if (result)
            {
                trainingProgram.TrainerId = tid;

                dbContext.Add(trainingProgram);
                dbContext.SaveChanges();
                Console.WriteLine("Training program created succesfully");
            }
            else
            {
                Console.WriteLine("Trainer does not exist");
            }

        }
        public void RegisterEmployee(AppDbContext dbContext)
        {
            Console.WriteLine("Enter Employee Name");
            Employee employee = new Employee();
            employee.Name = Console.ReadLine();
            Console.WriteLine("Enter Department Id");
            int did = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Email:");
            string email = Console.ReadLine();
            if (dbContext.Employees.Any(x=>x.Email == email))
            {
                Console.WriteLine("Email already registered");
                return;
            }
            employee.Email = email;
            var result = dbContext.Departments.Any(x=>x.DepartmentId == did);
            if (result)
            {
                employee.DepartmentId = did;

                dbContext.Employees.Add(employee);
                dbContext.SaveChanges();

                Console.WriteLine("Employee Register succesfully");
            }
            else
            {
                Console.WriteLine("department does not exist");
            }
        }

        public void enrollEmployeeInTraining(AppDbContext dbContext)
        {
            EmployeeTrainingProgram etp = new EmployeeTrainingProgram();

            Console.WriteLine("Enter Employee Id:");
            int empId = int.Parse(Console.ReadLine());
            if (!dbContext.Employees.Any(x => x.Id == empId))
            {
                Console.WriteLine("employee does not exist");
                return;
            }


            Console.WriteLine("Enter Training Program Id:");
            int programId = int.Parse(Console.ReadLine());
            if (!dbContext.TrainingPrograms.Any(x => x.Id == programId))
            {
                Console.WriteLine("training program does not exist");
                return;
            }

            var check = dbContext.EmployeeTrainingPrograms
                .FirstOrDefault(x => x.EmployeeId == empId
                                  && x.TrainingProgramId == programId);

            if (check != null)
            {
                Console.WriteLine("Employee already enrolled in this program");
                return;
            }
                etp.EmployeeId = empId;
                etp.TrainingProgramId = programId;
                etp.EnrollmentDate = DateTime.Now;
                etp.PerformanceScore = 0;

                dbContext.EmployeeTrainingPrograms.Add(etp);
                dbContext.SaveChanges();
               
                Console.WriteLine("Employee Enrolled Successfully");
            
        }

        public void showTrainingDetails(AppDbContext dbContext)
        {
            Console.WriteLine("Enter Training program Id");
            int tpid = int.Parse(Console.ReadLine());
            var result = dbContext.TrainingPrograms.AsNoTracking().Include(x=>x.Trainer)
                                                   .Include(x=>x.Junction)
                                                   .ThenInclude(x=>x.Employee)
                                                   .ThenInclude(x=>x.Department)
                                                   .FirstOrDefault(x=>x.Id == tpid);
            if(result == null)
            {
                Console.WriteLine("Program does not exist");
                return;
            }
            Console.WriteLine("\nTraining: " +result.Title);
            Console.WriteLine("Trainer: " +result.Trainer.TrainerName);
            Console.WriteLine("Duration: "+result.DurationInDays+" Days\n");

            if (result.Junction.Count() == 0)
            {
                Console.WriteLine("No Employees Enrolled Yet");
                return;
            }

            Console.WriteLine("Enrolled Employees :");
            Console.WriteLine("--------------------");
            Console.WriteLine("ID | NAME | DEPARTMENT | SCORE");
            foreach(var e in result.Junction)
            {
                Console.WriteLine($"{e.EmployeeId} | {e.Employee.Name} | {e.Employee.Department.DepName} | {e.PerformanceScore}");
            }

        }

        public void showDepartmentReport(AppDbContext dbContext)
        {
            Console.WriteLine("Enter Department Id");
            int did = int.Parse(Console.ReadLine());
            var result = dbContext.Departments.AsNoTracking().Include(x => x.Employees)
                                              .ThenInclude(x => x.Junction)
                                              .FirstOrDefault(x => x.DepartmentId == did);
            if (result == null)
            {
                Console.WriteLine("department does not exist");
                return;
            }
            int totalenrolledEmp = result.Employees.Count(x => x.Junction != null && x.Junction.Any());
            Console.WriteLine("Department : " + result.DepName);
            Console.WriteLine("Total Employees : " + result.Employees.Count());
            Console.WriteLine("Enrolled Employees :"+ totalenrolledEmp);
        }


        public void updateEmpPerformance(AppDbContext dbContext)
        {
            Console.WriteLine("Enter Employee Id");
            int empid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Training Program Id");
            int tpid = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new performance score (0-100)");
            int newscore = int.Parse(Console.ReadLine());
            if(newscore>100 && newscore < 0)
            {
                Console.WriteLine("enter valid score");
                return ;
            }
            var result = dbContext.EmployeeTrainingPrograms.FirstOrDefault(x=>x.EmployeeId == empid && x.TrainingProgramId == tpid);
            if (result == null)
            {
                Console.WriteLine("employee training program does not exist");
                return;
            }
            result.PerformanceScore = newscore;
            dbContext.SaveChanges();
            Console.WriteLine("employee performance updated succesfully");
        }

        public void deleteTrainingProgram(AppDbContext dbContext)
        {
            Console.WriteLine("Enter trainig program id to delete");
            int id  = int.Parse(Console.ReadLine());
            var result = dbContext.TrainingPrograms.FirstOrDefault(x=>x.Id == id);
            if (result == null) 
            {
                Console.WriteLine("Training program does not exist");
                return;
            }
            dbContext.TrainingPrograms.Remove(result);
            dbContext.SaveChanges();
            Console.WriteLine("Training Program Deleted Succesfully");
        }
    }
}