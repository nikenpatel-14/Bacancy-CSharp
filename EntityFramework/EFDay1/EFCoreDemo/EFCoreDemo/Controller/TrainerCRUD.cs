using EFCoreDemo.Data;
using EFCoreDemo.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Controller
{
    internal class TrainerCRUD
    {
        public void Run(EFCoreDbContext context)
        {
            Console.WriteLine("***CRUDOperation***");
            Console.WriteLine("1)Add Trainer\n2)Get Trainer\n3)Update Trainer\n4)Delete Trainer");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    addTrainer(context);
                    break;
                case 2:
                    getTrainer(context);
                    break;
                case 3:
                    updateTrainer(context);
                    break;
                case 4:
                    deleteTrainer(context);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
        }
        public void addTrainer(EFCoreDbContext dbContext)
        {
            Console.WriteLine("ENTER TRAINER NAME");
            Trainer trainer = new Trainer();
            trainer.Name = Console.ReadLine();
            Console.WriteLine("ENTER TRAINER'S EXPERIENCE IN YEAR");
            trainer.ExperienceInYears = Convert.ToInt32(Console.ReadLine());

            dbContext.Trainers.Add(trainer);
            Console.WriteLine("STAT BEFORE SAVECHANGES "+ dbContext.Entry(trainer).State);
            dbContext.SaveChanges();
            Console.WriteLine("STAT AFTER SAVECHANGES " + dbContext.Entry(trainer).State);
        }
        public void getTrainer(EFCoreDbContext dbContext)
        {
            Console.WriteLine("ENTER THE TRAINER ID");
            int tid = Convert.ToInt32(Console.ReadLine());
            var result = dbContext.Trainers.FirstOrDefault(x=>x.Id == tid);
            if (result == null)
            {
                Console.WriteLine("Trainer Does Not Exist");
            }
            else
            {
                Console.WriteLine($"Trainer Name = {result.Name},Trainer Experience= {result.ExperienceInYears} ");
            }
        }
        public void updateTrainer(EFCoreDbContext dbContext)
        {
            Console.WriteLine("ENTER THE TRAINER ID");
            int tid = Convert.ToInt32(Console.ReadLine());
            var result = dbContext.Trainers.FirstOrDefault(x=>x.Id == tid);
            if (result == null)
            {
                Console.WriteLine("Trainer Does Not Exist");
            }
            else
            {
                Console.WriteLine("what you want to modify");
                Console.WriteLine("1)Trainer Name\n2)Trainer Experience\n 3)Both ");
                int option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Trainer Name");
                        result.Name = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter Trainer Experience");
                        result.ExperienceInYears = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Enter Trainer Name");
                        result.Name = Console.ReadLine();
                        Console.WriteLine("Enter Trainer Experience");
                        result.ExperienceInYears = Convert.ToInt32(Console.ReadLine());
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
        public void deleteTrainer(EFCoreDbContext dbContext)
        {
            Console.WriteLine("Enter Trainer Id");
            int tid = int.Parse(Console.ReadLine());
            var result = dbContext.Trainers.FirstOrDefault( x=>x.Id == tid);
            if (result == null)
            {
                Console.WriteLine("Trainer Does Not Exist");
            }
            else
            {
                dbContext.Trainers.Remove(result);
                Console.WriteLine("STAT BEFORE SAVECHANGES " + dbContext.Entry(result).State);
                dbContext.SaveChanges();
                Console.WriteLine("STAT AFTER SAVECHANGES " + dbContext.Entry(result).State);
            }

        }
        
    }
}
