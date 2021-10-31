using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class RectangleArea:Rectangle
    {
        public override void GetArea()
        {
            Console.WriteLine("Enter the sides:");
            Console.Write("Length= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width= ");
            Side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine($"Area={Side1*Side2}");
            Console.ReadLine();
        }
    }
}
