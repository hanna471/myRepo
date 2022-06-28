using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    class exercise4
    {
        public void acceptString()
        {
            string str;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            Console.Write("The string you entered is : {0}\n", str);

            Console.ReadLine();
                
        }
        public void individualCharacters()
        {
            string str;
            int length = 0;

            Console.Write("Input the string : ");
            str = Console.ReadLine();
            Console.Write("The characters of the string are  :  ");
            while (length <= str.Length - 1)
            {
                Console.Write("{0} ", str[length]);
                length++;
            }
            Console.ReadLine();
        }
        public void findLengthString()
        {
            string str;
            int length = 0;

            Console.Write("Input the string : ");
            str = Console.ReadLine();

            foreach (char chr in str)
            {
                length += 1;

            }
            Console.Write("Length of the string is : {0}\n\n", length);

            Console.ReadLine();
        }
        public void countTotalNumber()
        {
            string str;
            int alphabet, digit, specialchar, i, l;
            alphabet = digit = specialchar = i = 0;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            l = str.Length;

            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    alphabet++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    digit++;
                }
                else
                {
                    specialchar++;
                }

                i++;
            }

            Console.Write("Number of Alphabets in the string is : {0}\n", alphabet);
            Console.Write("Number of Digits in the string is : {0}\n", digit);
            Console.Write("Number of Special characters in the string is : {0}\n\n", specialchar);

            Console.ReadLine();
        }
        public void IndividualCharactersString()
        {
            string str;
            int length = 0;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();

            length = str.Length - 1;
            Console.Write("The characters of the string in reverse are : \n");
            while (length >= 0)
            {
                Console.Write("{0} ", str[length]);
                length--;
            }
            Console.ReadLine();
        }
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
        public void countatotalnumber()
        {
            string str;
            int i, length, vowel, consonant;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();

            vowel = 0;
            consonant = 0;
            length = str.Length;

            for (i = 0; i < length; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowel++;
                }
                else if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    consonant++;
                }
            }
            Console.Write("\nThe total number of vowel in the string is : {0}\n", vowel);
            Console.Write("The total number of consonant in the string is : {0}\n\n", consonant);

            Console.ReadLine();
        }
        public void readstring()
        {
            string[] arr1;
            string temp;
            int num, i, j, lenghth;

            Console.Write("Input number of strings :");
            num = Convert.ToInt32(Console.ReadLine());
            arr1 = new string[num];
            Console.Write("Input {0} strings below :\n", num);
            for (i = 0; i < num; i++)
            {
                arr1[i] = Console.ReadLine();
            }
            lenghth = arr1.Length;

            for (i = 0; i < lenghth; i++)
            {
                for (j = 0; j < lenghth - 1; j++)
                {
                    if (arr1[j].CompareTo(arr1[j + 1]) > 0)
                    {
                        temp = arr1[j];
                        arr1[j] = arr1[j + 1];
                        arr1[j + 1] = temp;
                    }
                }
            }
            Console.Write("\n\nAfter sorting the array appears like : \n");
            for (i = 0; i < lenghth; i++)
            {
                Console.WriteLine(arr1[i] + " ");
            }

            Console.ReadLine();
        }
        public void findmaximumoccurring()
        {
            string str;
            int[] frequency = new int[255];
            int i = 0, max, l;
            int ascii;

            Console.Write("Enter the string : ");
            str = Console.ReadLine();
            l = str.Length;

            for (i = 0; i < 255; i++)
            {
                frequency[i] = 0;
            }
            // Reading frequency of each characters 
            i = 0;
            while (i < l)
            {
                ascii = (int)str[i];
                frequency[ascii] += 1;

                i++;
            }

            max = 0;
            for (i = 0; i < 255; i++)
            {
                if (i != 32)
                {
                    if (frequency[i] > frequency[max])
                        max = i;
                }
            }
            Console.Write("The Highest frequency of character '{0}' is appearing for number of times : {1} \n\n", (char)max, frequency[max]);

            Console.ReadLine();
        }
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
