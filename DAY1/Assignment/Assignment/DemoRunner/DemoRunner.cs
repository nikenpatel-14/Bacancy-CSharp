using System;
using System.Collections.Generic;
using System.Text;
using Assignment.Demo;

namespace Assignment.DemoRunner
{
    internal class DemoRunner
    {

        public void runAll()
        {


            Console.WriteLine("print name , machine name, current date\n");

            new BasicConsoleApp().run();




            Console.WriteLine("Nullable types example\n");
            new NullableTypes().run();


            Console.WriteLine("value vs reference type exampl\n");
            new ValueVsReference().run();


            Console.WriteLine("const and  readonly example\n");

            ConstReadonly cr = new ConstReadonly(101);
            
            Console.WriteLine(cr.orderId);

        }
    }
}
