using System;
using System.Collections.Generic;
using System.Text;

namespace Language_Basic
{
    class Class4
    {
        public void square()
        {
            double side, area;
            Console.WriteLine("Enter the Length of Side : ");
            side = Convert.ToDouble(Console.ReadLine());
            area = side * side;
            Console.WriteLine("\nArea of Square: " + area);
            Console.ReadKey();
        }
    }
}
