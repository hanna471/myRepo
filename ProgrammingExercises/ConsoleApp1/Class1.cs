using System;
using System.Collections.Generic;
using System.Text;

namespace Language_Basic
{
    class Class1
    {
      public void test()
        {
            Console.WriteLine("Size of char: " + sizeof(char));
            Console.WriteLine("Size of Short: " + sizeof(short));
            Console.WriteLine("Size of int: " + sizeof(int));
            Console.WriteLine("Size of long: " + sizeof(long));
            Console.WriteLine("Size of float: " + sizeof(float));
            Console.WriteLine("Size of double: " + sizeof(double));
            Console.ReadKey();
        }
    }
}