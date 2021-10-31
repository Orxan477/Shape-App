using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class ParalelogramArea:Paralelogram
    {
        public override void GetArea()
        {
            Console.WriteLine("Enter the sides:");
            Console.Write("Seat= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height lowered to the side");
            Console.Write("Height= ");
            Height = Convert.ToDouble(Console.ReadLine());   
            sum = Side1*Height;
            Console.WriteLine($"Area={sum}");
        }
    }
}
