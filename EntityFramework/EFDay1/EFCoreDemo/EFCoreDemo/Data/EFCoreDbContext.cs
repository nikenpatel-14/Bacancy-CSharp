using EFCoreDemo.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Data
{
    internal class EFCoreDbContext : DbContext
    {
        public DbSet<Student> Students {  get; set; }
        public DbSet<Course> Courses { get; set;  }

        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Batch> Batchs { get; set; }    

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.\\SQLEXPRESS ;Database =EFCoreDb ;Trusted_Connection = True;TrustServerCertificate=True;");
        }
    }
}

