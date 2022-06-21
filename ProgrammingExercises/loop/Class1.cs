using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    class Class1
    {
        public void alphabet()
        {
            char ch;

            Console.WriteLine("Alphabets from a - z are: ");
            for (ch = 'a'; ch <= 'z'; ch++)
            {
                //Printing all alphabets with tab
                Console.Write(ch + "\t");
            }

            Console.ReadLine();
        }
    }
}
