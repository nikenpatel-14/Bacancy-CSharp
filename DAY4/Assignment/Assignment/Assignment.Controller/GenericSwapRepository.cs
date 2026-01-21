using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Assignment.Controller
{
    internal class GenericSwapRepository
    {

        public void runAssignment3()
        {
            //same class name in diff namesapce GenericSwapRepository accesing Services namespace class
            Services.GenericSwapRepository genericSwapRepository = new Services.GenericSwapRepository();
            genericSwapRepository.run();
        }
    }
}
