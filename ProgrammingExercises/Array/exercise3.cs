using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Array
{
    class Exercise3

    {

        public void Length()
        {
            int[] arrayA = new int[10];
            int lengthA = arrayA.Length;
            Console.WriteLine("Length of ArrayA : {0}", +lengthA);
            long longLength = arrayA.LongLength;
            Console.WriteLine("Length of the Long Length Array  : {0}", longLength);
            int[,] twoD = new int[20, 50];
            Console.WriteLine("The Size of 2D Array is : {0}", twoD.Length);
            Console.ReadLine();
            int[] Arr = { 20, -10, -30, 0, 15, 10, 30 };

        }
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
        public void FindMinandMax()
        {
            int[] Arr = { 20, -10, -30, 0, 15, 10, 30 };
            Console.WriteLine("Maximum Element : " + Arr.Max());
            Console.WriteLine("Minimum Element : " + Arr.Min());
            Console.Read();
        }
        public void print()
        {
            int[] arr = new int[100];
            int i, num;

            //Enter size of array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Reading elements of array
            Console.WriteLine("Enter elements in array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("All negative elements in array are: ");
            for (i = 0; i < num; i++)
            {
                //Printing negative elements
                if (arr[i] < 0)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            Console.ReadLine();
        }
        public void count()
        {
            int[] arr = new int[100];
            int i, num, evennum, oddnum;

            ////Reads size and elements in array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter " + num + " elements in the array: ");

            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            evennum = 0; // Assuming 0 even numbers
            oddnum = 0; // Assuming 0 odd numbers

            for (i = 0; i < num; i++)
            {
                /* If the current element of array is evennumber then increment evennumber count */
                if (arr[i] % 2 == 0)
                {
                    evennum++;
                }
                else
                {
                    oddnum++; // increment oddnumber count
                }
            }

            Console.WriteLine("Total even  numbers: " + evennum);
            Console.WriteLine("Total odd numbers: " + oddnum);


            Console.ReadLine();
        }
        public void uniqueElement()
        {
            int[] arr = new int[100]; ;
            int i, j, k, size, isUnique;

            //Reads size of the array
            Console.WriteLine("Enter size of the array: ");
            size = Convert.ToInt32(Console.ReadLine());
            //Reads elements in array
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < size; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Removing all duplicate elements from the array

            for (i = 0; i < size; i++)
            {
                // Assuming  cuurent element is unique */
                isUnique = 1;

                for (j = i + 1; j < size; j++)
                {

                    //If any duplicate element is found

                    if (arr[i] == arr[j])
                    {
                        // Removing duplicate element
                        for (k = j; k < size - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }

                        size--;
                        j--;
                        isUnique = 0;
                    }
                }

                /*
            If array element is not unique
            then also remove the current element
             */
                if (isUnique != 1)
                {
                    for (j = i; j < size - 1; j++)
                    {
                        arr[j] = arr[j + 1];
                    }

                    size--;
                    i--;
                }
            }

            //Printing all unique elements in array
            Console.WriteLine("All unique elements in the array are: ");
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(arr[i] + "\t");
            }
            Console.ReadLine();
        }
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
        public void countNumber()
        {
            int i, j, count, num;

            int[] arr = new int[100];
            int[] frequency = new int[100];

            //Reads size of the array
            Console.WriteLine("Enter size of the array: ");
            num = Convert.ToInt32(Console.ReadLine());

            //Reads elements in array
            Console.WriteLine("Enter elements in the array: ");
            for (i = 0; i < num; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                //Initially initialize frequency variable to -1
                frequency[i] = -1;
            }


            for (i = 0; i < num; i++)
            {
                count = 1;
                for (j = i + 1; j < num; j++)
                {
                    //If duplicate element is found
                    if (arr[i] == arr[j])
                    {
                        count++;

                        //Make sure not to count frequency of same element again
                        frequency[j] = 0;
                    }
                }

                //If frequency of current element is not counted
                if (frequency[i] != 0)
                {
                    frequency[i] = count;
                }
            }


            //Print frequency of each element
            Console.WriteLine("\nFrequency of all elements of array : \n");
            for (i = 0; i < num; i++)
            {
                if (frequency[i] != 0)
                {
                    Console.WriteLine(arr[i] + " occurs " + frequency[i] + " times");
                }
            }


            Console.ReadLine();
        }
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
