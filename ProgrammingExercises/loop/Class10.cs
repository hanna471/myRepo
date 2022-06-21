using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    class Class10
    {
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
