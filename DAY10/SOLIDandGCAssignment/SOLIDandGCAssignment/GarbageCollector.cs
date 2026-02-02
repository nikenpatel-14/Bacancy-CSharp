using System;
using System.Collections.Generic;
using System.Text;

namespace SOLIDandGCAssignment
{
    class GarbageCollector
    {

        static void Main(string[] args)
        {

            for (int i = 0; i <3; i++)
            {

                //on every iteration old object became not reachable
                FinalizerClass finalizerClass = new FinalizerClass();
           

            }
            //USE this for  forcefully garbage colletion   
            GC.Collect();
            GC.WaitForPendingFinalizers();
            
        }


    }
    class FinalizerClass
    {
        public FinalizerClass()
        {
            Console.WriteLine("constructor called");
        }

        //Declaring finalizer
        ~FinalizerClass()
        {
            Console.WriteLine("finalizer called");
        }
    }
}
