using System;
using static System.Console;

namespace ConsoleApp78
{
   public class Rectangle
    {
        //variables
        int length;
        int width;
        int perimeter;


        public
        void getdata()
        {
            // anchor1
            return1:

            //ask for input
            WriteLine("Enter the length");

            // while not a number, show invalid else it takes value
            while (!int.TryParse(ReadLine(), out length) == true)
                {
                WriteLine("Invalid, type a number!");
                goto return1;
            }
            
            // anchor2
            return2:

            //ask for input
            WriteLine("Enter the width");

            // while not a number, show invalid else it takes value
            while (!int.TryParse(ReadLine(), out width) == true)
                {
                WriteLine("Invalid, type a number!");
                goto return2;
            }
            
        }
        public 
        void calculatePerimeter()
        {
            // calculate perimeter
            perimeter = 2 * (length + width);

            //display perimeter
            WriteLine("Perimeter : {0:0.00}", perimeter);
            ReadLine();
        }
    }
}
