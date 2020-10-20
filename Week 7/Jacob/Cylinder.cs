using System;
using static System.Console;

namespace ConsoleApp78
{
    public class Cylinder
    {
        // variables
        int radius;
        int height;
        double volume;

        public
        void getdata()
        {
            // anchor1
            return1:

            // ask for input
            WriteLine("Enter the radius");

            // while not a number, show invalid else it takes value
            while (!int.TryParse(ReadLine(), out radius) == true)
                {
                WriteLine("Invalid, type a number!");
                goto return1;
            }
            
            // anchor2
            return2:

            // ask for input
            WriteLine("Enter the height");

            // while not a number, show invalid else it takes value
            while (!int.TryParse(ReadLine(), out height) == true)
                {
                WriteLine("Invalid, type a number!");
                goto return2;
            }
            
        }
        public 
        void calculateVolume()
        {
            // calculate volume
            volume = 3.14 * radius * radius * height;

            //display volume
            WriteLine("Volume : {0:0.00}", volume);
            ReadLine();
        }
    }
}
