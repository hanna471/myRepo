using System;
using System.Collections.Generic;
using System.Text;

namespace String
{
    class Class7
    {
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
    }
}
