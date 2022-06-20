using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    class Class5
    {
        public void IndividualCharactersString()
        {
            string str;
            int length = 0;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();

            length = str.Length - 1;
            Console.Write("The characters of the string in reverse are : \n");
            while (length >= 0)
            {
                Console.Write("{0} ", str[length]);
                length--;
            }
            Console.ReadLine();
        }
    }
}
