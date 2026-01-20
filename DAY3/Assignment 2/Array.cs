using System;
using System.ComponentModel;


class Student
{
    public int id;
    public  required string name;
}


class Array
{
    static void Main(string[] args)
    {
        Student[] students = new Student[3];


        // add  in array

        students[0] = new Student { id = 1, name = " Niken" };
        students[1] = new Student { id = 2, name = "Mann" };
        students[2] = new Student { id = 3, name = "Ayush" };


        // search in array

        foreach (var s in students)
        {
            if ( s.id == 2)
            {
                Console.WriteLine($"Found: {s.name}");
            }
        }

        // UPDATE
        students[1].name = "Het";
        Console.WriteLine($"Name Updated : {students[1].name}");


        
    }
}