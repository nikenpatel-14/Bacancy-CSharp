using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Demo
{
    class NullableTypes
    {
        public void run()
        {


            int? age = null;
            long? phoneNumber = 9978210139;

            Console.WriteLine("User Information\n");

            if (age.HasValue)
            {
                Console.WriteLine("Age: " + age.Value);
            }
            else
            {
                Console.WriteLine("Age: Not provided");
            }

            long Phone = phoneNumber ?? 0;

            Console.WriteLine("Phone Number: " + (phoneNumber?.ToString()?? "Not provided"));
        }
        }
}
