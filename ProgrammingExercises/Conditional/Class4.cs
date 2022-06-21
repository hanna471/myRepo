using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional
{
    class Class4
    {
        public void integers()
        {
            int num1, num2;

            Console.WriteLine("Input the values for Number1 and Number2 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Number1 and Number2 are equal\n");
            }

            else
            {
                Console.WriteLine("Number1 and Number2 are not equal\n");
            }

            Console.ReadLine();
        }
    }
}
