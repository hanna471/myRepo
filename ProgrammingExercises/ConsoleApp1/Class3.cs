using System;
using System.Collections.Generic;
using System.Text;

namespace Language_Basic
{
    class Class3
    {
       public void ASCII()
        {
            char c;
            Console.WriteLine("Enter a character: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nASCII Value of " + c + " " + Convert.ToInt32(c));
            Console.ReadKey();
        }
    }
}
