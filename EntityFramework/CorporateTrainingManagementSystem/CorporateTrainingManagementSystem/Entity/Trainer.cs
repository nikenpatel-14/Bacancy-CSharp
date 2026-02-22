using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CorporateTrainingManagementSystem.Entity
{
    internal class Trainer
    {
        [Key]
        public int TrainerId { get; set; }
        [Required]
        public string TrainerName { get; set; }
        [Required]
        public string  ExpertiseLevel { get; set; }

        public List<TrainingProgram> TrainingPrograms { get; set; } = new List<TrainingProgram>();
    }
}
