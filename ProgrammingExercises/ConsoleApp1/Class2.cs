using System;
using System.Collections.Generic;
using System.Text;

namespace Language_Basic
{
    class Class2
    {
        public void circle()
        {
            double radius, area;
            Console.WriteLine("Enter Radius: ");
            radius = Convert.ToDouble(Console.ReadLine());
            area = Math.PI * radius * radius;
            Console.WriteLine("\nArea of circle: " + area);
            Console.ReadKey();
        }
    }
}
