using System;
using System.Collections.Generic;

class Student
{
	public int Id;
	public required string Name;
	public int Marks;
}

class Dictionary {


	static void Main(string[] args)
	{
		Dictionary<int, Student> students = new Dictionary<int, Student>();

		// add in dictionary
		students.Add(1, new Student { Id = 1, Name = "Niken", Marks = 80 });
		students.Add(2, new Student { Id = 2, Name = "Mannn", Marks = 75 });

		// search in dictionary
		if (students.ContainsKey(2))
		{
			Console.WriteLine($"student name: {students[2].Name}");
		}


		students[2].Marks = 95;
		Console.WriteLine($" {students[2].Name}  Marks Updated");
	}


}