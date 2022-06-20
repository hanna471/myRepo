using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Class5
    {
        public void findSum()
        {
            int[] arr = new int[100];
            int i, num, sum = 0;

            ////Reads size and elements in array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + num + " elements in the array: ");

            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Adding all elements        
            for (i = 0; i < num; i++)
            {
                sum = sum + arr[i]; // Calculating sum
            }

            Console.WriteLine("Sum of all elements of array: " + sum);

            Console.ReadLine();
        }
    }
}
