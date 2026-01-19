using Assignment.Services;
using System;

class Program {
    static void Main(String[] args)
    {
        Console.WriteLine("Assignment 1");
        new Calculator().run();

        Console.WriteLine();

        Console.WriteLine("Assignment 2");
        new ControlFlow().run();

        Console.WriteLine();


        Console.WriteLine("Assignment 3");
        new Utility().run();
    }



}
