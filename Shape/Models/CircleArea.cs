using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class CircleArea:Circle
    {
        public override void GetArea()
        {
            Console.WriteLine("Enter the Radius:");
            Radius = Convert.ToDouble(Console.ReadLine());
            sum = (Radius * Radius * 3.14);
            Console.WriteLine("-----------------");
            Console.WriteLine($"Area={sum}");
            Console.ReadLine();
        }
    }
}
