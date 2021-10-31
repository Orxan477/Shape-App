using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class VariousTriangles:Triangle
    {
        public override void GetArea()
        {
            double HalfPerimeter;
            Console.WriteLine("Enter the sides:");
            Console.Write("Side1= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side2= ");
            Side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side3= ");
            Side3 = Convert.ToDouble(Console.ReadLine());
            HalfPerimeter = (Side1 + Side2 + Side3) / 2;
            sum = Math.Sqrt(HalfPerimeter * (HalfPerimeter - Side1) * (HalfPerimeter - Side2) * (HalfPerimeter - Side3));
            Console.WriteLine("---------------------");
            Console.WriteLine($"Area={sum}");
            Console.ReadLine();
        }
    }
}
