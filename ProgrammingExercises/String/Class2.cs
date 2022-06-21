using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    class Class2
    {
        public void individualCharacters()
        {
            string str;
            int length = 0;

            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("The characters of the string are  :  ");
            while (length <= str.Length - 1)
            {
                Console.Write("{0} ", str[length]);
                length++;
            }
            Console.ReadLine();
        }
    }
}
