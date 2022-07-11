using System;
using System.Collections.Generic;
using System.Text;

namespace Language_Basic
{
    class exercise1
    {
      public void test()
        {
            Console.WriteLine("Size of char: " + sizeof(char));
            Console.WriteLine("Size of Short: " + sizeof(short));
            Console.WriteLine("Size of int: " + sizeof(int));
            Console.WriteLine("Size of long: " + sizeof(long));
            Console.WriteLine("Size of float: " + sizeof(float));
            Console.WriteLine("Size of double: " + sizeof(double));
            Console.ReadKey();
        }
        public void circle()
        {
            double radius, area;
            Console.WriteLine("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("\nArea of circle: " + area);
            Console.ReadKey();
        }
        public void ASCII()
        {
            char c;
            Console.WriteLine("Enter a character: ");
            c = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("\nASCII Value of " + c + " " + Convert.ToInt32(c));
            Console.ReadKey();
        }
        public void square()
        {
            double side, area;
            Console.WriteLine("Enter the Length of Side : ");
            side = Convert.ToDouble(Console.ReadLine());
            area = side * side;
            Console.WriteLine("\nArea of Square: " + area);
            Console.ReadKey();
        }
        public void rectangle()
        {
            double length, breadth, area;
            Console.WriteLine("Enter length of rectangle : ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle : ");
            breadth = Convert.ToDouble(Console.ReadLine());
            area = length * breadth;
            Console.WriteLine("\nArea of rectangle: " + area);
            Console.ReadKey();
        }
        public void convert()
        {
            int days, years, weeks;
            Console.WriteLine("Enter days:");
            days = Convert.ToInt32(Console.ReadLine());
            years = (days / 365);
            weeks = (days % 365) / 7;
            days = days - ((years * 365) + (weeks * 7));
            Console.WriteLine("Years : " + years);
            Console.WriteLine("weeks : " + weeks);
            Console.WriteLine("Days : " + days);

            Console.ReadKey();
        }
    }
}