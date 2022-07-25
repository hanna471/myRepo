using System;
using System.Collections.Generic;
using System.Text;

namespace Conditional
{
    class Exercise
    {
        public void character()
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());


            // Condition for vowel checking
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {

                Console.WriteLine(ch + " is Vowel.");

            }
            else if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is Consonant.");
            }

            Console.ReadLine();
        }
        public void alphabet()
        {
            char ch;

            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

            // Alphabet checking condition
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + " is an Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "is a Digit. ");
            }
            else
            {
                Console.WriteLine(ch + "is a Special character.. ");
            }

            Console.ReadLine();
        }
        public void day()
        {
            int week;

            Console.WriteLine("Enter week number (1-7): ");
            week = Convert.ToInt32(Console.ReadLine());

            if (week == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (week == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (week == 3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (week == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (week == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (week == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (week == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Invalid Input! Please enter week in between 1-7.");
            }

            Console.ReadLine();
        }
        public void integers()
        {
            int num1, num2;

            Console.WriteLine("Input the values for Number1 and Number2 : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Number1 and Number2 are equal\n");
            }

            else
            {
                Console.WriteLine("Number1 and Number2 are not equal\n");
            }

            Console.ReadLine();
        }
        public void determine()
        {
            int Candiateage;

            Console.WriteLine("Input the age of the candidate : ");
            Candiateage = Convert.ToInt32(Console.ReadLine());

            if (Candiateage < 18)
            {
                Console.WriteLine("Sorry, You are not eligible to caste your vote.\n");
                Console.WriteLine(18 - Candiateage + "You would be able to caste your vote after %d year.\n");
            }

            else
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.\n");
            }

            Console.ReadLine();
        }
        public void eligibility()
        {
            int p, c, m;

            Console.Write("\n\n");
            Console.Write("Find eligibility for admission :\n");
            Console.Write("----------------------------------");
            Console.Write("\n\n");

            Console.Write("Eligibility Criteria :\n");
            Console.Write("Marks in Maths >=65\n");
            Console.Write("and Marks in Phy >=55\n");
            Console.Write("and Marks in Chem>=50\n");
            Console.Write("and Total in all three subject >=180\n");
            Console.Write("or Total in Maths and Physics >=140\n");
            Console.Write("-------------------------------------\n");


            Console.Write("Input the marks obtained in Physics :");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Chemistry :");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the marks obtained in Mathematics :");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Total marks of Maths, Physics and Chemistry : {0}\n", m + p + c);
            Console.Write("Total marks of Maths and  Physics : {0}\n", m + p);

            if (m >= 65)
                if (p >= 55)
                    if (c >= 50)
                        if ((m + p + c) >= 180 || (m + p) >= 140)
                            Console.Write("The  candidate is eligible for admission.\n");
                        else
                            Console.Write("The candidate is not eligible.\n\n");
                    else
                        Console.Write("The candidate is not eligible.\n\n");
                else
                    Console.Write("The candidate is not eligible.\n\n");
            else
                Console.Write("The candidate is not eligible.\n\n");

            Console.ReadLine();
        }
        public void caculate()
        {
            double rl, phy, che, ca, total;
            double per;
            string nm, div;

            Console.Write("\n\n");
            Console.Write("Calculate the total, percentage and division to take marks of three subjects:\n");
            Console.Write("-------------------------------------------------------------------------------");
            Console.Write("\n\n");


            Console.Write("Input the Roll Number of the student :");
            rl = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Name of the Student :");
            nm = Console.ReadLine();

            Console.Write("Input  the marks of Physics : ");
            phy = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of  Chemistry : ");
            che = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input  the marks of Computer Application : ");
            ca = Convert.ToInt32(Console.ReadLine());

            total = phy + che + ca;
            per = total / 3.0;
            if (per >= 60)
                div = "First";
            else
                if (per < 60 && per >= 48)
                div = "Second";
            else
                    if (per < 48 && per >= 36)
                div = "Pass";
            else
                div = "Fail";

            Console.Write("\nRoll No : {0}\nName of Student : {1}\n", rl, nm);
            Console.Write("Marks in Physics : {0}\nMarks in Chemistry : {1}\nMarks in Computer Application : {2}\n", phy, che, ca);
            Console.Write("Total Marks = {0}\nPercentage = {1}\nDivision = {2}\n", total, per, div);

            Console.ReadLine();
        }
        public void month()
        {
            int month;

            Console.WriteLine("Enter month number (1-12): ");
            month = Convert.ToInt32(Console.ReadLine());

            if (month == 1)
            {
                Console.WriteLine("Enter month : January \nNo. of days : 31 days");
            }
            else if (month == 2)
            {
                Console.WriteLine("Enter month : February \nNo. of days : 28 or 29 days");
            }
            else if (month == 3)
            {
                Console.WriteLine("Enter month : March \nNo. of days : 31 days");
            }
            else if (month == 4)
            {
                Console.WriteLine("Enter month : April \nNo. of days : 30 days");
            }
            else if (month == 5)
            {
                Console.WriteLine("Enter month : May \nNo. of days : 31 days");
            }
            else if (month == 6)
            {
                Console.WriteLine("Enter month : June \nNo. of days : 30 days");
            }
            else if (month == 7)
            {
                Console.WriteLine("Enter month : July \nNo. of days : 31 days");
            }
            else if (month == 8)
            {
                Console.WriteLine("Enter month : August \nNo. of days : 31 days");
            }
            else if (month == 9)
            {
                Console.WriteLine("Enter month : September \nNo. of days : 30 days");
            }
            else if (month == 10)
            {
                Console.WriteLine("Enter month : October \nNo. of days : 31 days");
            }
            else if (month == 11)
            {
                Console.WriteLine("Enter month : November \nNo. of days : 30 days");
            }
            else if (month == 12)
            {
                Console.WriteLine("Enter month : December \nNo. of days : 31 days"); ;
            }
            else
            {
                Console.WriteLine("Invalid input! Please enter month number between (1-12).");
            }
            Console.ReadLine();
        }
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
        public void triangle1()
        {
            int anglea, angleb, anglec, sum;

            Console.WriteLine("Input three angles of triangle : ");
            anglea = Convert.ToInt32(Console.ReadLine());
            angleb = Convert.ToInt32(Console.ReadLine());
            anglec = Convert.ToInt32(Console.ReadLine());

            // Calculate the sum of all angles of triangle 
            sum = anglea + angleb + anglec;

            // Check whether sum=180 then its a valid triangle otherwise invalid triangle
            if (sum == 180)
            {
                Console.WriteLine("It is a valid triangle.\n");
            }
            else
            {
                Console.WriteLine("It is a invalid triangle.\n");
            }

            Console.ReadLine();
        }
    }
}
