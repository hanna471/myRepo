using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    class exercise2

    {
        public void alphabet()
        {
            char ch;

            Console.WriteLine("Alphabets from a - z are: ");
            for (ch = 'a'; ch <= 'z'; ch++)
            {
                //Printing all alphabets with tab
                Console.Write(ch + "\t");
            }

            Console.ReadLine();
        }
        public void ASCIIvalues()
        {
            int i;

            // Printing ASCII values from 0 to 255
            for (i = 0; i <= 255; i++)
            {
                Console.WriteLine("ASCII value of " + i + " = " + i);
            }
            Console.ReadLine();
        }
        public void table()
        {
            int i, num;

            //Reading number
            Console.WriteLine("Enter number to print table: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 10; i++)
            {
                //Printing table of number entered by user            
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);
            }
            Console.ReadLine();
        }
        public void sum()
        {
            int num, total;

            //Reading number
            Console.WriteLine("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Adding sum of digit in total variable
            for (total = 0; num > 0; num = num / 10)
                total = total + (num % 10);

            //Printing sum of digit
            Console.WriteLine("Sum of digits: " + total);

            Console.ReadLine();
        }
        public void naturalNumber()
        {
            int i, num;

            //Read a number from user
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            /*Running loop from the number entered by user,
              and Decrementing by 1*/
            for (i = num; i >= 1; i--)
            {
                Console.WriteLine("\n" + i);
            }

            Console.ReadLine();
        }
        public void evenNumbers()
        {
            int i, num, sum = 0;

            // Reading number
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= num; i += 2)
            {
                //Adding current even number to sum variable
                sum += i;
            }
            Console.WriteLine("Sum of all even number between 1 to " + num + " = " + sum);

            Console.ReadLine();
        }
        public void oddNumbers()
        {
            int i, num, sum = 0;

            // Reading number
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i += 2)
            {
                //Adding current odd number to sum variable
                sum += i;
            }
            Console.WriteLine("Sum of all odd numbers between 1 to " + num + " = " + sum);

            Console.ReadLine();
        }
        public void digit()
        {
            int num, last, first, temp, count = 0;
            double swap;

            // Reading number
            Console.Write("Enter any number: ");
            num = Convert.ToInt32(Console.ReadLine());

            temp = num;
            last = temp % 10;
            count = (int)Math.Log10(temp);

            while (temp >= 10)
            {
                temp /= 10;
            }
            first = temp;
            swap = (last * Math.Pow(10, count) + first) + (num - (first * Math.Pow(10, count) + last));

            Console.WriteLine("Last Digit:" + last);

            Console.WriteLine("First Digit:" + first);

            Console.WriteLine(num + " is swapped to " + swap);

            Console.ReadLine();
        }
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
        public void number()
        {
            int lower, higher, i, temp1, temp2, remainder, n = 0;
            double result = 0;

            // Reading number
            Console.Write("Please Enter two numbers: ");
            lower = Convert.ToInt32(Console.ReadLine());
            higher = Convert.ToInt32(Console.ReadLine());

            Console.Write("Armstrong numbers between " + lower + " and " + higher + " are: ");

            for (i = lower + 1; i < higher; ++i)
            {
                temp2 = i;
                temp1 = i;

                // number of digits calculation
                while (temp1 != 0)
                {
                    temp1 /= 10;
                    ++n;
                }

                // result contains sum of nth power of its digits
                while (temp2 != 0)
                {
                    remainder = temp2 % 10;
                    result += Math.Pow(remainder, n);
                    temp2 /= 10;
                }

                // checking if number i is equal to the sum of nth power of its digits
                if (result == i)
                {
                    Console.WriteLine(i);
                }

                // resetting the values to check Armstrong number for next iteration
                n = 0;
                result = 0;

            }

            Console.ReadLine();
        }
    }
}
