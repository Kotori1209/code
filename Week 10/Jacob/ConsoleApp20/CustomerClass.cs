using System;


namespace ConsoleApp20
{
    class CustomerClass
    {
        private string cFullName;
        private string cDOB;
        private int cMonthNumber;
        private string cLastName;
        private int cBirthYear;
        private string cPurchaseMonth;

        // Property pFullName().
        public string CustomerFullName
        {

            // Getter.
            get
            {

                //Return the customer name.
                return cFullName;
            }

            // Setter.
            set
            {

                // Set the customer name.
                cFullName = value;
            }
        }

        // Property pBirthdate().
        public string CustomerBirthdate
        {

            // Getter.
            get
            {

                // Return the customer birth date.
                return cDOB;
            }

            // Setter.
            set
            {

                // Set the customer birth date.
                cDOB = value;
            }
        }

        // Property pMonthNumber().
        public int CustomerMonthNumber
        {

            // Getter.
            get
            {

                // Return the customer month number.
                return cMonthNumber;
            }

            // Setter.
            set
            {

                // Set the customer month number.
                cMonthNumber = value;
            }
        }

        // Read only property pLastName().
        public string CustomerLastName
        {

            // Getter.
            get
            {

                // Function call.
                NameParser(cFullName);

                // Return the customer last name.
                return cLastName;
            }
        }

        // Read only property pBirthYear().
        public int CustomerBirthYear
        {

            // Getter.
            get
            {

                // Function call.
                BirthdateParser(cDOB);

                // Return the customer birth year.
                return cBirthYear;
            }
        }

        // Read only property pPurchaseMonth().
        public string CustomerPurchaseMonth
        {

            // Getter.
            get
            {

                // Function call.
                MonthParser(cMonthNumber);

                // Return the customer purchase month.
                return cPurchaseMonth;
            }
        }

        // Default Constructor
        public CustomerClass() { }

        // Parameterized Constructor
        public CustomerClass(string f, string b, int m)
        {
            cFullName = f;
            CustomerBirthdate = b;
            cMonthNumber = m;
        }

        // Method NameParser().
        // To get the last name from the full name.
        public void NameParser(string f)
        {

            // Split the full name and place in array.
            string[] partition = f.Split(' ');

            // Assign partition[1] as last name.
            cLastName = partition[1];
        }

        // Method BirthdateParser().
        // To get the birthdate from year.
        public void BirthdateParser(string b)
        {

            // Split the year.
            string[] partition = b.Split('/');

            // Assign partition[2] as birth year
            cBirthYear = Convert.ToInt32(partition[2]);
        }

        // Method MonthParser().
        // To determine the month name from the month number.
        public void MonthParser(int m)
        {

            // Array for Name Of Months.
            string[] NameOfMonths =
            { "Jan", "Feb", "Mar",
            "Apr", "May", "Jun",
            "Jul", "Aug", "Sep",
            "Oct", "Nov", "Dec" };

            NameOfMonths[0] = NameOfMonths[0].TrimStart('0');

            // Assign NameOfMonths[m - 1] as purchase month.
            cPurchaseMonth = NameOfMonths[m - 1];
        }
    }
}
