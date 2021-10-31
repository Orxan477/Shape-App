using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class EquilateralTriangle : Triangle
    {
        public override void GetArea()
        {

            Console.WriteLine("Enter the side:");
            Console.Write("Side= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            sum = ((Math.Sqrt(3)) * (Side1 * Side1) / 4);
            Console.WriteLine("---------------------");
            Console.WriteLine($"Area={sum}");
        }
    }
}
