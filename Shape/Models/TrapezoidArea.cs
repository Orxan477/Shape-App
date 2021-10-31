using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class TrapezoidArea:Trapezoid
    {
        public override void GetArea()
        {
            Console.WriteLine("Enter the sides:");
            Console.Write("Seat1= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Seat2= ");
            Side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height= ");
            Height = Convert.ToDouble(Console.ReadLine());  
            sum = (((Side1 + Side2)/2)*Height);
            Console.WriteLine("---------------------");
            Console.WriteLine($"Area={sum}");
           // Console.ReadLine();
        }
    }
}
