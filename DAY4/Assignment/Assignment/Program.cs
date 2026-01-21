using System;
using Assignment.Assignment.Controller;


class Program
{
    static void Main(string[] args)
    {

        //same class name in diff namesapce (EnumStruct) accesing controller namespace class

        //EnumStruct enumStruct = new EnumStruct();
        //enumStruct.runAssignment1();


        //same class name in diff namesapce (LambdaExp) accesing controller namespace class

        //LambdaExp lambdaExp = new LambdaExp();
        //lambdaExp.runAssignment2();


        //same class name in diff namesapce (GenericSwapRepository) accesing controller namespace class
        GenericSwapRepository genericSwapRepository = new GenericSwapRepository();
        genericSwapRepository.runAssignment3();




    }

}