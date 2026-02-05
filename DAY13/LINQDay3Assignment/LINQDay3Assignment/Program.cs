
using LINQDay3Assignment.Services;

class Program
{
    static void Main(string[] args)
    {
        //Task1-------
        //Services.AssignmentTask1();

        //Task2-------
        //Services.AssignmentTask2();

        //Task3-------
        //Services.AssignmentTask3();

        //Task4-------
        //Services.AssignmentTask4();

        //Task7-------
        //Services.AssignmentTask7();

        //Task8-------
        //Services.AssignmentTask8();

        //Task9-------
        //Services.AssignmentTask9();

        //Task10------

        //BEST PRACTICE IN LINQ
        //When to use ToList()
        //using tolist generally in linq for immediate execution
        //generally linq will have deffered execution so sometimes it create overhead for system for getting result every time to iterate in loop
        //by using tolist it gives immediate execution,stable result and convert over result in the list

        //Avoid multiple enumeration
        //multipe enumeration means  execute for each loop multiple times by to reduce it we can use imemdiate execution

        //Use Any() instead of Count() > 0
        //if we use count() > 0 then it iterates throgh entire source to get the total count and then it check condition
        //if its is greater than 0 it returns true
        //where any start checking if any condition meets it returns true and stops the execution
        //so it create less system overhead

        //Avoid loop IF LINQ POSSIBLE
        //LINQ IS  MORE READABLE AND MAINTAINABLE
        //LINQ MAKE WRITING OF CODE MORE EASIER BY IT METHODS LIKE WHERE,SELECT,GROUPBY,ORDERBY

        //N+1 query problem
        //N+1 problem means if we access the querry result by iterating loop like fetching order list and then geting product name by iteration
        //so querry will execute for first to fetch result and the Fot N times for N orderitems
        //so avoid that we can directly use selectmany


    }
}