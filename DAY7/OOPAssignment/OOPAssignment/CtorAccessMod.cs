using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace OOPAssignment
{
    internal class CtorAccessMod
    {
        static void Main(string[] args)
        {
            
            UserProfile user = new UserProfile("niken","mail","123");

            //we can not access password fields because of private
            //Console.WriteLine($"password of {user.name} is {user.changePassword}");

            //to access private field we need to use method
            Console.WriteLine($"passsword of username : {user.userName} is : " + user.getPassword());
        }

    }
    class UserProfile 
    {
        public string userName;
        // if we make password public then it can be directly accessible
        private string password;
        public string email;

        public UserProfile(string userName,string email, string password)
        {
            //ctor validation for email
            if (Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                this.userName = userName;
                this.password = password;
                this.email = email;
            }
            else
            {
                Console.WriteLine("email is not valid");
            }
        }
        public string getPassword()
        {
            return password; 
        }
    }

}
