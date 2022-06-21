using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Class2
    {
        public void Array()
        {
            int[][] jagArray = new int[3][];
            jagArray[0] = new int[2];
            jagArray[0][0] = 12;
            jagArray[0][1] = 13;
            jagArray[1] = new int[1] { 12 };
            jagArray[2] = new int[3] { 15, 16, 17 };
            for (int i = 0; i < jagArray.Length; i++)
            {
                int[] innerArray = jagArray[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    Console.WriteLine(innerArray[a] + " ");
                }
            }
            Console.Read();
        }
    }
}
