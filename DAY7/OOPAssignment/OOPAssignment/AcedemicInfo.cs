using System;
using System.Collections.Generic;
using System.Text;

namespace OOPAssignment
{
    internal  partial class  Student
    {
        public string Course;
        public string Sem;
        public double Gpa;
        public string Grade;

        public void printStuDetail()
        {
            Console.WriteLine("Personal Information");
            Console.WriteLine($"Student NAME : {Name}");
            Console.WriteLine($"Student AGE : {Age}");
            Console.WriteLine($"Student ADDRESS: {Address}");
            Console.WriteLine($"Student BLOODGROUP : {BloodGroup}");
            Console.WriteLine($"Student ID : {Id}");
            Console.WriteLine("Acedemic Information");
            Console.WriteLine($"Student COURSE : {Course}");
            Console.WriteLine($"Student SEM : {Sem}");
            Console.WriteLine($"Student GPA : {Gpa}");
            Console.WriteLine($"Student GRADE : {Grade}");
        }
    }
}
