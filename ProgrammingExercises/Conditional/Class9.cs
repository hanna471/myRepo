using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional
{
    class Class9
    {
        public void number()
        {
            int amount;

            int note1, note2, note5, note10, note20, note50, note100, note500;

            note1 = note2 = note5 = note10 = note20 = note50 = note100 = note500 = 0;

            Console.WriteLine("Enter amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            if (amount >= 500)
            {
                note500 = amount / 500;
                amount -= note500 * 500;
            }
            if (amount >= 100)
            {
                note100 = amount / 100;
                amount -= note100 * 100;
            }
            if (amount >= 50)
            {
                note50 = amount / 50;
                amount -= note50 * 50;
            }
            if (amount >= 20)
            {
                note20 = amount / 20;
                amount -= note20 * 20;
            }
            if (amount >= 10)
            {
                note10 = amount / 10;
                amount -= note10 * 10;
            }
            if (amount >= 5)
            {
                note5 = amount / 5;
                amount -= note5 * 5;
            }
            if (amount >= 2)
            {
                note2 = amount / 2;
                amount -= note2 * 2;
            }
            if (amount >= 1)
            {
                note1 = amount;
            }

            Console.WriteLine("Total number of notes = \n");
            Console.WriteLine("500 = " + note500);
            Console.WriteLine("100 = " + note100);
            Console.WriteLine("50 = " + note50);
            Console.WriteLine("20 = " + note20);
            Console.WriteLine("10 = " + note10);
            Console.WriteLine("5 = " + note5);
            Console.WriteLine("2 = " + note2);
            Console.WriteLine("1 = " + note1);

            Console.ReadLine();
        }
    }
}
