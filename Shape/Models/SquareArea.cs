using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class SquareArea : Square
    {
        public override void GetArea()
        {
            Console.Write("Enter the side:");
            Console.Write("Side 1= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine($"Area={Side1*Side1}");
        }
    }
}
