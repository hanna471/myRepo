using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional
{
    class Class8
    {
        public void month()
        {
            int month;

            Console.WriteLine("Enter month number (1-12): ");
            month = Convert.ToInt32(Console.ReadLine());

            if (month == 1)
            {
                Console.WriteLine("Enter month : January \nNo. of days : 31 days");
            }
            else if (month == 2)
            {
                Console.WriteLine("Enter month : February \nNo. of days : 28 or 29 days");
            }
            else if (month == 3)
            {
                Console.WriteLine("Enter month : March \nNo. of days : 31 days");
            }
            else if (month == 4)
            {
                Console.WriteLine("Enter month : April \nNo. of days : 30 days");
            }
            else if (month == 5)
            {
                Console.WriteLine("Enter month : May \nNo. of days : 31 days");
            }
            else if (month == 6)
            {
                Console.WriteLine("Enter month : June \nNo. of days : 30 days");
            }
            else if (month == 7)
            {
                Console.WriteLine("Enter month : July \nNo. of days : 31 days");
            }
            else if (month == 8)
            {
                Console.WriteLine("Enter month : August \nNo. of days : 31 days");
            }
            else if (month == 9)
            {
                Console.WriteLine("Enter month : September \nNo. of days : 30 days");
            }
            else if (month == 10)
            {
                Console.WriteLine("Enter month : October \nNo. of days : 31 days");
            }
            else if (month == 11)
            {
                Console.WriteLine("Enter month : November \nNo. of days : 30 days");
            }
            else if (month == 12)
            {
                Console.WriteLine("Enter month : December \nNo. of days : 31 days"); ;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter month number between (1-12).");
            }
            Console.ReadLine();
        }
    }
}
