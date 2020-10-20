/*Group
 * Group Number: Group #1
 * Group Members: Jacob B, Charles B, Tyler D, Bozhou C, Cyrus C
 */

/*Info
 * Programmer: Charlie Beals
 * Date: 2020-10-20
 * Purpose: Console app that takes rainfall for each month and outputs a report
 *
 * Class: CITP 180
 * Assignment: Chapter 7 - Programming Excercise 1
 */
using System;
using System.Linq;
using static System.Console;

namespace Ch7Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create array to hold month names
            string[] months = new string[12];
            months[0] = "Jan";
            months[1] = "Feb";
            months[2] = "Mar";
            months[3] = "Apr";
            months[4] = "May";
            months[5] = "Jun";
            months[6] = "Jul";
            months[7] = "Aug";
            months[8] = "Sep";
            months[9] = "Oct";
            months[10] = "Nov";
            months[11] = "Dec";

            // Create array to hold rainfall values
            double[] rainfallValues = new double[12];

            // Get rainfall value for each month
            for (int i = 0; i < rainfallValues.Length; i++)
            {
                rainfallValues[i] = PromptForDouble("Rainfall in " + months[i]);
                
            }

            DisplayTwoArrays(months, rainfallValues);
        }

        public static double PromptForDouble(string key)
        {
            // Initialize values
            double value = 0;
            bool enterAgain = true;

            // Confirm entered value is a double before accepting it, otherwise continue to ask the user
            while (enterAgain == true)
            {
                string inValue;
                Write("Please enter " + key + ": ");
                inValue = ReadLine();
                if (double.TryParse(inValue, out value) == false)
                {
                    WriteLine("invalid double value");
                    enterAgain = true;
                }
                else
                {
                    enterAgain = false;
                }
            }
            return value;
        }

        public static double CalculateMean(double[] values)
        {
            double mean = values.Average();
            return mean;
        }

        public static void DisplayTwoArrays(string[] keys, double[] values)
        {
            // Calculate the mean rainfall
            double mean = CalculateMean(values);

            // Print table header
            WriteLine("    Month    CM    Var");

            // For each month, print the rainfall value
            for (int i=0; i < keys.Length; i++)
            {
                // Calculate the variance
                double variance = Math.Abs(mean - values[i]);

                // Print the row
                WriteLine("    " + keys[i] + "      " + values[i] + "     " + Math.Round(variance, 2));
            }
            // Print the previously calculated mean
            WriteLine("Average Rainfall for current year: " + Math.Round(mean, 2) + " cm.");
        }
    }
}
