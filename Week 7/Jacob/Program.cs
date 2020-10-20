#region About this program

/*Group
 * Group Number: Group #1
 * Group Members: Jacob B, Charles B, Tyler D, Bozhou C, Cyrus C
 */

/*Info
 * Programmer: Jacob Brookhouse
 * Date: 10/7/2020
 * Purpose: Console app that allows you to select between circle, rectangle, and cylinder.
 * Then lets you enter data that calculates area(circle), volume(cylinder), and perimeter(rectangle).
 *
 * Class: CITP 180
 * Assignment: Chapter 5 - Programming Excercise 8
 */

#endregion

using System;
using static System.Console;

namespace ConsoleApp78
{
    class Program
    {
        static 
        void Main(string[] args)
        {
            // For selection
            int opt;

            // while true run again and again, mainly close when done
            while(true) 

            {
                // Output options 1-3
                WriteLine("1. CIRCLE");

                WriteLine("2. RECTANGLE");

                WriteLine("3. CYLINDER");

                // Anchor to come back to
                Return1:

                // While input is not a number display not valid input
                while (!int.TryParse(ReadLine(), out opt) == true)

                {
                    // Says that it is not valid
                    WriteLine("This is not valid input, please type 1-3");
                    // Go back to anchor above
                    goto Return1;
                }
                   
                    switch (opt)

                    {
                  
                case 1: // if '1' then circle

                    Circle circ = new Circle();
                    circ.getdata();
                    circ.calculateArea();
                    break;

                case 2: // if '2' then rectangle

                    Rectangle rect = new Rectangle();
                    rect.getdata();
                    rect.calculatePerimeter();
                    break;

                case 3: // if '3' then cylinder

                    Cylinder cyli = new Cylinder();
                    cyli.getdata();
                    cyli.calculateVolume();
                    break;

                default: // if anything but 1-3 then invalid

                    WriteLine("Invalid entry");

                    ReadLine();
                    // if not 1-3 then go back to anchor above
                    goto Return1;

                    }
            }
        }
    }
}
