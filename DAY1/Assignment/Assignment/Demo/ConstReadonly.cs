using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment.Demo
{
    internal class ConstReadonly
    {



        public const int taxRate = 10;

        public readonly int orderId;
        public ConstReadonly( int orderId)
        {

           this.orderId = orderId;


        }




        public void attemptTOmodify()
        {
            //Compile time error: The left-hand side of an assignment must be a variable, property or indexer
            //taxRate = 20;

            //compileitme error: A readonly field cannot be assigned to(except in a constructor or init - only setter of the type in which the field is defined or a variable initializer)
            //orderId = 101;


        }





    }
}
