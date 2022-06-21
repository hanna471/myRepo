using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    class Class6
    {
        public void copyOneString()
        {
            string str1;
            int i, length;

            Console.Write("Enter the string : ");
            str1 = Console.ReadLine();

            length = str1.Length;
            string[] str2 = new string[length];

            /* Copies string1 to string2 character by character */
            i = 0;
            while (i < length)
            {
                string tmp = str1[i].ToString();
                str2[i] = tmp;
                i++;
            }
            Console.Write("\nThe First string is : {0}\n", str1);
            Console.Write("The Second string is : {0}\n", string.Join("", str2));
            Console.Write("Number of characters copied : {0}\n\n", i);

            Console.ReadLine();
        }
    }
}
