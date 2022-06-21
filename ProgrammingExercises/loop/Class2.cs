using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    class Class2
    {
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
    }
}
