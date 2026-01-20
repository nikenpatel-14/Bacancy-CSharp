using System;

class Student {
    public int Id;
    public required string Name;
    public int Marks;
}


class List { 
    static void Main(string[] args)
    {

        List<Student> students =new List<Student>();


        //add in list

        students.Add(new Student { Id = 1, Name = "Niken" , Marks = 80});
        students.Add(new Student { Id = 2, Name = "Mann", Marks = 100 });

        //search in list
        Student s = students.Find(s => s.Id == 1);
        Console.WriteLine($"student name : {s.Name}   student Marks : {s.Marks}");

        //update in list

        s.Marks = 90;
        Console.WriteLine($"student update marks is {s.Marks}");




    }
}
