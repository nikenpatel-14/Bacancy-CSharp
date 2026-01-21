using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Assignment.Controller
{
    internal class LambdaExp
    {
        public void runAssignment2()
        {
            //same class name in diff namesapce LambdaExp accesing Services namespace class


            Services.LambdaExp lambdaExp = new Services.LambdaExp();
            lambdaExp.run();
        }
    }
}
