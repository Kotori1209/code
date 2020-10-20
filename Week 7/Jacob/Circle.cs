using System;
using System.ComponentModel;
using static System.Console;

namespace ConsoleApp78
{
  public class Circle
    {
        //variables
        double radius;
        double area;


        public
        void getdata()
        {
            //anchor1
            return1:

            //ask for input
            WriteLine("Enter the radius");

            // while not a number, show invalid else it takes value
            while (!double.TryParse(ReadLine(), out radius) == true)
                {
                WriteLine("Invalid, type a number!");
                goto return1;
            }
            
        }
        public 
        void calculateArea()
        {
            // calculate area
            area = radius * radius * 3.14;

            //display area
            WriteLine("Area : {0:0.00}", area);
            ReadLine();
        }
    }
}
