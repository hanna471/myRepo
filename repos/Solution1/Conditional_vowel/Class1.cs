using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_vowel
{
    class Class1
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("enter a character");
            ch = Console.ReadKey().KeyChar;
            switch (ch)
            {
                case 'a':
                case 'A':
                case 'e':
                case 'E':
                case 'i':
                case 'I':
                case 'o':
                case 'O':
                case 'u':
                case 'U':
                    Console.WriteLine($"\n\t{ch} is a Vowel");

                    break;
                default:
                    Console.WriteLine($"\n\t{ch} is a Consonant");
                    break;


            }
            Console.ReadLine();
        }

    }
}
