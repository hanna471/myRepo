﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Class8
    {
        public void copyElement()
        {
            int[] arr = new int[100];

            int[] first = new int[100];
            int[] second = new int[100];

            int i, num;

            //Reads size of the array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            //Reads elements in array
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                first[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Copy all elements from first array to second array
            for (i = 0; i < num; i++)
            {
                second[i] = first[i];
            }

            //Printing all elements of first array entered by user
            Console.WriteLine("Elements of first array are:");
            for (i = 0; i < num; i++)
            {
                Console.Write(first[i] + "\t");
            }

            //Printing all elements of second array
            Console.WriteLine("\nElements of second array are:");
            for (i = 0; i < num; i++)
            {
                Console.Write(second[i] + "\t");
            }


            Console.ReadLine();
        }
    }
}
