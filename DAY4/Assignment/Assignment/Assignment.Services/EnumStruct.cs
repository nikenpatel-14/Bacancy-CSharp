using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Assignment.Assignment.Services
{


    enum OrderStratus {
        Delivered,
        Panding,
        Shipped,
        OutForDelivery
    }
    struct Coordinates {
        public int X;
        public int Y;

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;

        }
    }


    class Points {
        public int X;
        public int Y;
        public Points(int x, int y)
        {
            X = x;
            Y = y;
        }
    }



    internal class EnumStruct
    {
       public void run()
        {

            // this code for ENUM of orderstatus

            Console.WriteLine("Orderstatus by use of enum");
            OrderStratus orderStatus = OrderStratus.Delivered;
            Console.WriteLine("order status : " + orderStatus);

            // this code for coordinates in struct

            Coordinates coordinates1;
            coordinates1.X = 10;
            coordinates1.Y = 30;

            Console.WriteLine("\n\nCoordinates by use of struct");

            Console.WriteLine(coordinates1.Y);
            Console.WriteLine(coordinates1.X);


            //struct vs class

            Console.WriteLine("\n\nstruct vs class behaviour");

            // struct behaviour
            Console.WriteLine("\nBy passing the struct  object as and parameter");
            Coordinates coordinates = new Coordinates(10,30);
            Console.WriteLine("Before update value of X : " + coordinates.X);
            updateCoordinates(coordinates);
            Console.WriteLine("After update value of X : " + coordinates.X);


            //class behaviour
            Console.WriteLine("\nBy passing class object as an parameter");
            Points points = new Points(10,30);
            Console.WriteLine("Before update value of X : " + points.X);
            updatePoints(points);
            Console.WriteLine("After update value of X : " + points.X);



        }

         void updatePoints(Points p)
        {
            p.X = 70;
        }

         void updateCoordinates(Coordinates cn)
        {
            cn.X = 100;
        }

    }
}
