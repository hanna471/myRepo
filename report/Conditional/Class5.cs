using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional
{
    class Class5
    {
        public void determine()
        {
            int Candiateage;

            Console.WriteLine("Input the age of the candidate : ");
            Candiateage = Convert.ToInt32(Console.ReadLine());

            if (Candiateage < 18)
            {
                Console.WriteLine("Sorry, You are not eligible to caste your vote.\n");
                Console.WriteLine(18 - Candiateage + "You would be able to caste your vote after %d year.\n");
            }

            else
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.\n");
            }

            Console.ReadLine();
        }
    }
}
