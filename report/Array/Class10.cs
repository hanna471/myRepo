using System;
using System.Collections.Generic;
using System.Text;

namespace Array
{
    class Class10
    {
        public void deleteDuplicateElements()
        {
            int[] arr = new int[100];
            int num; // Total number of elements in array
            int i, j, k;

            //Reads size of the array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Reads elements in array
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }


            // Finding all duplicate elements in array

            for (i = 0; i < num; i++)
            {
                for (j = i + 1; j < num; j++)
                {
                    //If any duplicate found */
                    if (arr[i] == arr[j])
                    {
                        // Delete the current duplicate element
                        for (k = j; k < num; k++)
                        {
                            arr[k] = arr[k + 1];
                        }

                        //Decrement size after removing duplicate element
                        num--;

                        // If shifting of elements occur then don't increment j
                        j--;
                    }
                }
            }

            // Print array after deleting duplicate elements
            Console.WriteLine("\nArray elements after deleting duplicates : ");
            for (i = 0; i < num; i++)
            {
                Console.WriteLine(arr[i]);
            }

            Console.ReadLine();
        }

    }
}
