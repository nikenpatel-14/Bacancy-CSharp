using CorporateTrainingManagementSystem.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CorporateTrainingManagementSystem.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<TrainingProgram> TrainingPrograms { get; set; }
        public DbSet<EmployeeTrainingProgram> EmployeeTrainingPrograms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =.\\SQLEXPRESS ;Database =CTMSystemDB ;Trusted_Connection = True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeTrainingProgram>()
                        .HasKey(e => new { e.EmployeeId, e.TrainingProgramId });

            modelBuilder.Entity<EmployeeTrainingProgram>()
                .HasOne(e => e.TrainingProgram)
                .WithMany(p => p.Junction)
                .HasForeignKey(e => e.TrainingProgramId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EmployeeTrainingProgram>()
                .HasOne(e => e.Employee)
                .WithMany(e => e.Junction)
                .HasForeignKey(e => e.EmployeeId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
