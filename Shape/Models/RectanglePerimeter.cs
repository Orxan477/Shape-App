using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class RectanglePerimeter:Rectangle
    {
        public override void GetPerimeter()
        {
            Console.WriteLine("Enter the sides:");
            Console.Write("Length= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Width= ");
            Side2 = Convert.ToDouble(Console.ReadLine());
            sum = ((Side1 + Side2) * 2);
            Console.WriteLine("---------------------");
            Console.WriteLine($"Perimeter={sum}");
          //  Console.ReadLine();
        }
    }
}
