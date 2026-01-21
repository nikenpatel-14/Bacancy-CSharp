using System;
using System.Collections.Generic;
using System.Text;
using Assignment.Assignment.Services;


namespace Assignment.Assignment.Controller
{
    internal class EnumStruct
    {

       public void runAssignment1()
        {

            //same class name in diff namesapce EnumStruct accesing Services namespace class


            Services.EnumStruct enumStructService = new Services.EnumStruct();
            enumStructService.run();
        }

    }
}
