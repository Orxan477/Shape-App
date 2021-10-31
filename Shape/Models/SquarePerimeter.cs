using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class SquarePerimeter : Square
    {

        public override void GetPerimeter()
        {
            double sum = 0;
            Console.WriteLine("Enter the side:");
            Console.Write("Side 1= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            sum = Side1 * 4;
            Console.WriteLine("---------------------");
            Console.WriteLine($"Perimeter={sum}");
           // Console.ReadLine();
        }
    }
}
