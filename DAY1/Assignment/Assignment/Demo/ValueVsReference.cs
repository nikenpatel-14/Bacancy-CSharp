using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Demo
{
    internal class ValueVsReference
    {
   public void run()
        {

            int number = 10;


            Person person = new Person();
            person.Name = "Niken";

            Console.WriteLine("Before method calls:");
            Console.WriteLine("Number = " + number);
            Console.WriteLine("Person Name = " + person.Name);

            Console.WriteLine("\nCalling methods...\n");

            ModifyValueType(number);
            ModifyReferenceType(person);

            Console.WriteLine("After method calls:");
            Console.WriteLine("Number = " + number);
            Console.WriteLine("Person Name = " + person.Name);
        }

        static void ModifyValueType(int num)
        {
            num = 50;
            Console.WriteLine("Inside ModifyValueType: num = " + num);
        }

        static void ModifyReferenceType(Person p)
        {
            p.Name = "Patel";
            Console.WriteLine("Inside ModifyReferenceType: Name = " + p.Name);
        }
    }

    class Person
    {
        public string Name { get; set; }
    }

}
