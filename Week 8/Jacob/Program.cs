
#region About this program

/*Group
 * Group Number: Group #1
 * Group Members: Jacob B, Charles B, Tyler D, Bozhou C, Cyrus C
 */

/*Info
 * Programmer: Jacob Brookhouse
 * Date: 10/14/2020
 * Purpose: Console app that uses arrays, shows messabox and also displays output in console.
 *
 * Class: CITP 180
 * Assignment: Chapter 7 - Programming Excercise 3
 */

#endregion

using System;
using System.Windows.Forms;
using static System.Console;

namespace C7E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "Working with arrays | Chapter 7 - Exercise 3 ";

            // Variables
            // Create an array as double and store 10 numbers, going by a factor of 2.
            double[] array1 = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 };

            // Create an array as double and store 10 numbers, going by a factor of 3.
            double[] array2 = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30 };

            // Create an array as double and assign it as a new double equal to array2.length
            // so it knows the length of values it can accept because we did not assign any
            // values to array3 just the amount.
            double[] array3 = new double[array2.Length];

            // Output string, will be used to display output in messagebox
            string outputString = "";

            // For loop because we know the length of time we need to execute
            // Do until 'i' reaches the length of array2
            for (int i = 0; i < array2.Length; i++)

            {
                // Assign the values in array3 equal to the array1 * array2
                array3[i] = array1[i] * array2[i];

                // Assign outputString equal to itself + show array values, so each time
                // we go through the 'for loop' it assigns each value, also seperated by
                // a single newline.
                outputString = outputString + array1[i] + " * " + array2[i] + " = " + array3[i] + "\n";

            }

            // MessageBox text as string so we can just use 'mess' for the text of the messagebox
            string mess = "Array1 is the first column, Array2 is the second column.\nArray1 is muliplied by Array2 and Array3 is the last column\nor the product of the two arrays.\n\n";

            // MessageBox that pops up to show a message and the outputString, 
            // also added a title, icon, and told it to use the 'ok' buttons
            MessageBox.Show(mess + outputString, "Sum of the arrays", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            // After messagebox 'ok' button is cliced show in console.
            WriteLine(mess + outputString);
            // Read
            ReadLine();

        }

    }

}
