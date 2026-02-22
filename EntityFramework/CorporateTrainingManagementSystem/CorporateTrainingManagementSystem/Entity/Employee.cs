using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CorporateTrainingManagementSystem.Entity
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }


        public List<EmployeeTrainingProgram> Junction = new List<EmployeeTrainingProgram>(); 
    }
}
