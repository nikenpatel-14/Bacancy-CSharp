using System;
using System.Collections.Generic;
using System.Text;

namespace EFCoreDemo.Model
{
    internal class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int Price { get; set; }
        public int DurationInMonths { get; set; }
    }
}
