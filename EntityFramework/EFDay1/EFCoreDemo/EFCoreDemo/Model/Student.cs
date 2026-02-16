using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Model
{
    internal class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
