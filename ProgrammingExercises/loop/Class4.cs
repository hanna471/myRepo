using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    class Class4
    {
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
    }
}
