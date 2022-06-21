using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    class Class3
    {
        public void findLengthString()
        {
            string str;
            int length = 0;

            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                length += 1;

            }
            Console.Write("Length of the string is : {0}\n\n", length);

            Console.ReadLine();
        }
    }
}
