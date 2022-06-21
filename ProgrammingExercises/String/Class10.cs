using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    class Class10
    {
        public void findthenumberoftimes() 
        
        {
            string str;
            string findstring;
            int start = 0;
            int cnt = -1;
            int index = -1;

            Console.Write("Input the original string : ");
            str = Console.ReadLine();
            Console.Write("Input the string to be searched for : ");
            findstring = Console.ReadLine();

            while (start != -1)
            {
                start = str.IndexOf(findstring, index + 1);
                cnt += 1;
                index = start;
            }
            Console.Write("The string '{0}' occurs " + cnt + " times.\n", findstring);

            Console.ReadLine();
        }
    }
}
