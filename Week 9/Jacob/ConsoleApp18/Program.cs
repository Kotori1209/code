
#region About this program

/*Group
 * Group Number: Group #1
 * Group Members: Jacob B, Charles B, Tyler D, Bozhou C, Cyrus C
 */

/*Info
 * Programmer: Jacob Brookhouse
 * Date: 10/20/2020
 * Purpose: Console app that uses arrays, asks for rain amount for each month
 * then calculates the mean and displays an output.
 *
 * Class: CITP 180
 * Assignment: Chapter 7 - Programming Excercise 1
 */

#endregion

using System;
using static System.Console;

namespace ConsoleApp18
{
    class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            // Months array as string to store month names
            string[] months = { "January", "February", "March", "April", "May", "June", 
                "July", "August", "September", "October", "November", "December" };

            // RainFall array as double to store rain ammount
            double[] rainFall = new double[12];

            // GetData, asks for rainfall ammount for each month
            GetData(months, rainFall);

            // Assign the mean double equal to the calculated mean
            double mean = CalculateMean(rainFall);

            // Output results
            ShowReport(months, rainFall, mean);

            Read();
        }

        // Method that reads rainfall data from user
        static void GetData(string[] months, double[] rainFall)
        {
            // terating over each month and reading values
            for (int i = 0; i < 12; i++)
            {
                Write("\n Enter rainfall of " + months[i] + ": ");

                while (!double.TryParse(ReadLine(), out rainFall[i]) == true)
                {
                    WriteLine("Not Number");
                }
            }
        }

        // Method that calculates the mean
        static double CalculateMean(double[] rainFall)
        {
            double total = 0;

            // Iterating over array
            for (int i = 0; i < 12; i++)
            {
                // Accumulating rainfall
                total += rainFall[i];
            }

            return (total / 12.0);
        }

        // Method that prints results
        static void ShowReport(string[] months, double[] rainFall, double mean)
        {
            // Printing header
            WriteLine("-------------------------------");
            WriteLine("  Month    |  Rainfall    |  Variance  ");
            WriteLine("-------------------------------");

            // Printing month wise data
            for (int i = 0; i < 12; i++)
            {
                WriteLine(String.Format("{0,-10} | {1,-10} | {2,5:0.0}", 
                    months[i], rainFall[i], (mean - rainFall[i])));
            }
            WriteLine("-------------------------------");

            // Printing average rainfall
            WriteLine("\n Average rainfall of the year: " + 
                mean.ToString("0.00") + " \n");
        }
    }
}
