using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class CirclePerimeter:Circle
    {
        public override void GetPerimeter()
        {
            Console.WriteLine("Enter the Radius:");
            Radius = Convert.ToDouble(Console.ReadLine());
            sum = (2 * Radius * 3.14);
            Console.WriteLine("---------------------");
            Console.WriteLine($"Length={sum}");
        }
    }
}
