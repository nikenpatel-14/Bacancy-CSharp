using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using CorporateTrainingManagementSystem.Entity;

namespace CorporateTrainingManagementSystem.Entity
{
    internal class TrainingProgram
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public DateOnly StartDate { get; set; }
        public int DurationInDays { get; set; }

        [ForeignKey("Trainer")]
        public int TrainerId { get; set; }

        public Trainer Trainer { get; set; }


        public List<EmployeeTrainingProgram> Junction = new List<EmployeeTrainingProgram>();
    }
}
