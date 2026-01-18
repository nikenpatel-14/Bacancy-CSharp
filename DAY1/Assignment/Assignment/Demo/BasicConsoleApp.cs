using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Demo
{
    internal class BasicConsoleApp
    {
        public void run() {

            string name = "Niken Patel";
            DateTime currentDate = DateTime.Now;
            string machineName = Environment.MachineName;

            Console.WriteLine("Name         : " + name);
            Console.WriteLine("Current Date : " + currentDate.ToString("dd-MM-yyyy"));
            Console.WriteLine("Machine Name : " + machineName);
        }
    }
}
