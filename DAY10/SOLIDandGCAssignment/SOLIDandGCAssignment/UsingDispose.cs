using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SOLIDandGCAssignment
{
    internal class UsingDispose
    {

        static void Main(string[] args)
        {
            // by implementing using it automatically execute the dispose
            using(Logger logger = new Logger())
            {
                logger.log("file logged");

            }
        }
    }
    class Logger : IDisposable 
    {
        public Logger()
        {
            Console.WriteLine("log intialized");
        }
        public void log(string message) { 
        
            Console.WriteLine(message);
        }
        //Dispose method for logger 
        public void Dispose()
        {
            Console.WriteLine("dispose called");
        }
    }

}

