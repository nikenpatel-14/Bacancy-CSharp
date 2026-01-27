using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment
{
    internal partial class Student
    {
        public int Id;
        public string Name;
        public int Age;
        public string Address;
        public string BloodGroup;
    }

    //Both partial class considered as one single class(compiler merge both partial class)
    class Program 
    {
        static void Main(string[] args)
        {
            Student student = new Student();    
            student.Id = 1;
            student.Name = "Niken";
            student.Age = 20;
            student.Address = "mehsana";
            student.BloodGroup = "o+";
            student.Course = "B.E";
            student.Sem = "8";
            student.Gpa = 8.8;
            student.Grade = "AB";


            student.printStuDetail();

        }
    }

}
