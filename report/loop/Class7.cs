using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    class Class7
    {
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
    }
}
