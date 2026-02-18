using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFCoreDemo.Model
{
    internal class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Required]
        public string Title { get; set; }
        [Column(TypeName = "decimal(10,1)")]
        public int Price { get; set; }

        public int DurationInMonths { get; set; }

        public List<Batch> batches { get; set; } = new List<Batch>();


        public List<Student> Students { get; set; } = new List<Student>();
    }
}
