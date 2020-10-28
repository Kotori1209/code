using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace ch8_ex4
{
    class Label
    {
        // Create class members
        private string full_name;
        private DateTime birthday;
        private int subscription_month;
        private int zip_code;
        private string first_name;
        private string last_name;
        private string month_string;
        private int year_born;
        private int full_name_length;
        private string short_zip_code;

        // Default Constructor
        public Label()
        {
        }

        // Property Accessors
        public string Full_Name
        {
            get
            {
                return full_name;
            }
            set
            {
                full_name = value;
            }
        }
        public DateTime Birthday
        {
            get
            {
                return birthday;
            }
            set
            {
                birthday = value;
            }
        }
        public int Subscription_Month
        {
            get
            {
                return subscription_month;
            }
            set
            {
                subscription_month = value;
            }
        }
        public int Zip_Code
        {
            get
            {
                return zip_code;
            }
            set
            {
                zip_code = value;
            }
        }
        public string First_Name
        {
            get
            {
                return first_name;
            }
            set
            {
                first_name = value;
            }
        }
        public string Last_Name
        {
            get
            {
                return last_name;
            }
            set
            {
                last_name = value;
            }
        }
        public string Month_String
        {
            get
            {
                return month_string;
            }
            set
            {
                month_string = value;
            }
        }
        public int Year_Born
        {
            get
            {
                return year_born;
            }
            set
            {
                year_born = value;
            }
        }
        public int Full_Name_Length
        {
            get
            {
                return full_name_length;
            }
            set
            {
                full_name_length = value;
            }
        }
        public string Short_Zip_Code
        {
            get
            {
                return short_zip_code;
            }
            set
            {
                short_zip_code = value;
            }
        }


        // Main Process Label Method
        public void ProcessLabelText()
        {
            SplitName(Full_Name);
            MonthToString(Subscription_Month);
            SetYearBorn(Birthday);
            GetFullNameLength(Full_Name);
            GetShortZipCode(Zip_Code);
        }

        public void PrintLabel()
        {
            WriteLine("Label for " + full_name + " is:");
            WriteLine();
            WriteLine(Last_Name + Year_Born + Full_Name_Length + Month_String + Short_Zip_Code);
        }

        // Separate first and last names
        public void SplitName(string full_name)
        {
            string[] NameTemp = full_name.Split(" ");
            First_Name = NameTemp[0];
            Last_Name = NameTemp[1];
        }
        // Convert month to a string
        public void MonthToString(int month_int)
        {
            switch (month_int)
            {
                case 1:
                    Month_String = "jan";
                    break;
                case 2:
                    Month_String = "feb";
                    break;
                case 3:
                    Month_String = "mar";
                    break;
                case 4:
                    Month_String = "apr";
                    break;
                case 5:
                    Month_String = "may";
                    break;
                case 6:
                    Month_String = "jun";
                    break;
                case 7:
                    Month_String = "jul";
                    break;
                case 8:
                    Month_String = "aug";
                    break;
                case 9:
                    Month_String = "sep";
                    break;
                case 10:
                    Month_String = "oct";
                    break;
                case 11:
                    Month_String = "nov";
                    break;
                case 12:
                    Month_String = "dec";
                    break;
                default:
                    Month_String = "err";
                    break;
            }
        }
        // Set 2-digit year born
        public void SetYearBorn(DateTime birthday)
        {
            Year_Born = Convert.ToInt32(birthday.ToString("yy"));
        }
        // Get length of full name with spaces removed
        public void GetFullNameLength(string full_name)
        {
            string full_name_no_end_spaces = full_name.Trim();
            string full_name_no_space = full_name_no_end_spaces.Replace(" ", "");
            Full_Name_Length = full_name_no_space.Length;
        }
        // Get last two digits of zip code
        public void GetShortZipCode(int zip_code)
        {
            Short_Zip_Code = (zip_code % 100).ToString().PadLeft(2, '0');
        }
    }
}
