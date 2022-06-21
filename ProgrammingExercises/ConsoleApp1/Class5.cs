using System;
using System.Collections.Generic;
using System.Text;

namespace Language_Basic
{
    class Class5
    {
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

    }
}
