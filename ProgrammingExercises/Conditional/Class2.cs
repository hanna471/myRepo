using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional
{
    class Class2
    {
        public void alphabet()
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            // Alphabet checking condition
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is an Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "is a Digit. ");
            }
            else
            {
                Console.WriteLine(ch + "is a Special character.. ");
            }

            Console.ReadLine();
        }
    }
}
