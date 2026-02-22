using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CorporateTrainingManagementSystem.Entity
{
    internal class EmployeeTrainingProgram
    {
       
        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
        
        [ForeignKey("TrainingProgram")]
        public int TrainingProgramId { get; set; }

        public TrainingProgram TrainingProgram { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public decimal PerformanceScore { get; set; }
    }
}
