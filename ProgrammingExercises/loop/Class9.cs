using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    class Class9
    {
        public void lastDigit()
        {
            int num, sum = 0, firstDigit, lastDigit;

            // Reading number
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            lastDigit = num % 10;

            firstDigit = num;

            while (num >= 10)
            {
                num = num / 10;
            }
            firstDigit = num;

            //Finding sum of first and last digit
            sum = firstDigit + lastDigit;

            Console.WriteLine("Sum of first and last digit: " + sum);

            Console.ReadLine();
        }
    }
}
