using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class TrianglePerimeter:Triangle
    {
        public override void GetPerimeter()
        {
            Console.WriteLine("Enter the sides:");
            Console.Write("Side1= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side2= ");
            Side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side3= ");
            Side3 = Convert.ToDouble(Console.ReadLine());
            sum = Side1 + Side2 + Side3;
            Console.WriteLine("---------------------");
            Console.WriteLine($"Perimeter={sum}");
        }
    }
}
