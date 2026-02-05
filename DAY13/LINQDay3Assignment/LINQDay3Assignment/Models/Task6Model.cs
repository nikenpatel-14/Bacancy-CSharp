using System;
using System.Collections.Generic;
using System.Text;

namespace LINQDay3Assignment.Models
{
    
    
    internal class EmployeeJoin
       {
           //employee model Used at task 2 jopin operation
           public int EmployeeID { get; set; }
           public string EmpName { get; set; }
           public int EmpSalary { get; set; }
           public int DepID { get; set; }


        }
    internal class Department
    {

        //Deparment  model having two feild Id and DepartmentName
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }


}
