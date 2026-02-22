using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CorporateTrainingManagementSystem.Entity
{
    internal class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        public string DepName { get; set; }

        public string DepLocation { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

    }
}
