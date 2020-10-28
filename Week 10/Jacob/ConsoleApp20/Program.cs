

/*Group
 * Group Number: Group #1
 * Group Members: Jacob B, Charles B, Tyler D, Bozhou C, Cyrus C
 */

/*Info
 * Programmer: Jacob Brookhouse
 * Date: 10/26/2020
 * Purpose: Console App that asks info from the user to generate a code for a mailing label
 *
 * Class: CITP 180
 * Assignment: Chapter 8 - Programming Excercise 4
 */


using System;
using static System.Console;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string RunVal;
            char RunAgain;

            // Do While loop.
            do
            {

                // Call to GetDetails().
                GetDetails(out string FullName, out string DOB, out int MonthNumber, out int Zip);

                // Creating new instance of CustomerClass.
                CustomerClass CustomerC = new CustomerClass(FullName, DOB, MonthNumber);

                // Output.
                WriteLine("Customer Code : {0}{1}{2}{3}{4}", CustomerC.CustomerLastName, 
                    CustomerC.CustomerBirthYear % 100, CustomerC.CustomerFullName.Length.ToString(), 
                    CustomerC.CustomerPurchaseMonth, Zip % 100);

                // Print a new line.
                WriteLine();

                // Prompt the user.
                WriteLine("Do you want to generate a new mailing label code? [y/n]: ");

                // Get the input.
                RunVal = ReadLine();

                // Convert input.
                RunAgain = Convert.ToChar(RunVal);

            }

            // End of loop.
            while ((RunAgain == 'Y') || (RunAgain == 'y'));

        }
        // Method GetDetails() to get the Customer Details.
        public static void GetDetails(out string FullName, out string DOB, out int MonthNumber, out int Zip)
        {

            // Display message.
            WriteLine("Customer Application");

            // Write a new line.
            WriteLine();

            // Prompt the user for full name.
            Write("Name (FirstName LastName): ");

            // Get the input.
            FullName = ReadLine();

            // Prompt the user for Birth date.
            Write("Birthdate (mm/dd/yyyy): ");

            // Get the input.
            DOB = ReadLine();

            // Prompt the user for Month subscription.
            Write("Subscription purchased (Month Number): ");

            ReturnMonth:

            // Get the input. While not an int error else accept
            while (!int.TryParse(ReadLine(), out MonthNumber) == true ) {
                Write("Error: Not a number! Enter an integer.\nPlease re-enter month as a number: ");
            }

            // IF MonthNumber is greater than 12 or less than 1 then error
            if (MonthNumber > 12 || MonthNumber < 1)
            {
                Write("Error: Out of range! Range(1-12).\nPlease re-enter month: ");
                goto ReturnMonth;
            }
          

            // Prompt the user for ZipCode.
            Write("Customer ZipCode (12345): ");

            ReturnZip:

            // Get the input. while not an int error else accept 
            while (!int.TryParse(ReadLine(), out Zip) == true)
            {
                Write("Error: One or more characters is not a number!\nPlease re-enter ZipCode: ");
                goto ReturnZip;
            }
        }
    }
}