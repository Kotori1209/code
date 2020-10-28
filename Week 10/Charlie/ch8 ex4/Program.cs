// Title: MagazineCode
// Group: Group 1
// Programer: Charlie Beals
// Date: 2020-10-28
// Class: C#.NET Programming
// Assignment: Ch 8, Ex 4
using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using static System.Console;

namespace ch8_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Magazine label creator");

            // Create mailing label
            Label myLabel = new Label();

            // Get user's full name ("Charlie Beals")
            myLabel.Full_Name = GetFullName();

            // Get users birthdate (mm/dd/yyyy)
            myLabel.Birthday = GetBirthday();

            // Get month (1=Jan, 2=Feb) subscription purchased
            myLabel.Subscription_Month = GetSubMonthInt();

            // Get zip code
            myLabel.Zip_Code = GetZipCode();

            // Create customer code
            myLabel.ProcessLabelText();

            // Print customer code
            myLabel.PrintLabel();
        }

        // Get full name, validate input
        static string GetFullName()
        {
            bool valid_input = false;
            string input = "";
            while (valid_input == false)
            {
                WriteLine("Input first and last name separated by a space (e.g. \"Charlie Beals\")");
                input = ReadLine();
                input = input.Trim();
                Regex reg = new Regex(@"[A-Za-z]+ [A-za-z]+");
                if (!reg.IsMatch(input)){
                    valid_input = false;
                }
                else
                {
                    valid_input = true;
                }
            }
            return input;
        }
        // Get birthday, validate input
        public static DateTime GetBirthday()
        {
            DateTime value = DateTime.Now;
            bool enterAgain = true;
            while (enterAgain == true)
            {
                string inValue;
                Write("Please enter your birthday (mm/dd/yyyy): ");
                inValue = ReadLine();
                if (DateTime.TryParse(inValue, out value) == false)
                {
                    WriteLine("invalid DateTime value");
                    enterAgain = true;
                }
                else
                {
                    enterAgain = false;
                }
            }
            return value;
        }
        // Get month as an interger, validate input
        public static int GetSubMonthInt()
        {
            bool valid_input = false;
            int output = 0;
            while (valid_input == false)
            {
                WriteLine("Please enter the month number you purchased your subscription (1-12): ");
                string input = ReadLine();
                if (int.TryParse(input, out output) == false)
                {
                    WriteLine("Invalid input.");
                    valid_input = false;
                }
                else
                {
                    if (output > 12 || output < 1)
                    {
                        WriteLine("Invalid input.");
                        valid_input = false;
                    }
                    else
                    {
                        valid_input = true;
                    }
                }
            }
            return output;
        }
        // Get zip code, validate input
        public static int GetZipCode()
        {
            bool valid_input = false;
            int output = 0;
            while (valid_input == false)
            {
                WriteLine("Please enter your zip code: ");
                string input = ReadLine();
                if (int.TryParse(input, out output) == false)
                {
                    WriteLine("Invalid input.");
                    valid_input = false;
                }
                else
                {
                    if (output.ToString().Length < 1 || output.ToString().Length > 5)
                    {
                        WriteLine("Invalid input.");
                        valid_input = false;
                    }
                    else
                    {
                        valid_input = true;
                    }
                }
            }
            return output;
        }

    }
}
