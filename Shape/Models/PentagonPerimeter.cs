using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class PentagonPerimeter:Pentagon
    {
        public override void GetPerimeter()
        {
            Console.WriteLine("Enter the sides:");
            Console.Write("Side= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            sum = Side1 * 5;
            Console.WriteLine("---------------------");
            Console.WriteLine($"Perimeter={sum}");
            //Console.ReadLine();
        }
    }
}
