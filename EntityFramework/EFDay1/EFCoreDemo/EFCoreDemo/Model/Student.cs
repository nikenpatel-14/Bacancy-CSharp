using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreDemo.Model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required, MaxLength(50)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }

        public virtual List<Course> Courses { get; set; } = new List<Course>();

    }
}
