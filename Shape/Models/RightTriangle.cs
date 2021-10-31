using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class RightTriangle:Triangle
    {
        public override void GetArea()
        {
            Console.WriteLine("Enter the sides:");
            Console.Write("Height= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Seat=");
            Seat = Convert.ToDouble(Console.ReadLine());
            sum = (Side1 * Seat) / 2;
            Console.WriteLine($"Area={sum}");
        }
    }
}
