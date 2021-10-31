using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class IsoscelesTriangles:Triangle
    {
        public override void GetArea()
        {
            double Height=0;
            Console.WriteLine("Enter the sides:");
            Console.Write("Side= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Seat= ");
            Seat = Convert.ToDouble(Console.ReadLine());
            Height = (Side1 * Side1) - ((Seat / 2) * (Seat / 2));
            Height = Math.Sqrt(Height);
            sum = (Seat * Height) / 2;
            Console.WriteLine("---------------------");
            Console.WriteLine($"Area={sum}");
           // Console.ReadLine();
        }
    }
}
