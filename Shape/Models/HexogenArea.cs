using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class HexogenArea:Hexogen
    {
        public override void GetArea()
        {
            Console.WriteLine("Enter the sides:");
            Console.Write("Side= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            sum = (3*(Math.Sqrt(3))*(Side1*Side1))/2;
            Console.WriteLine("---------------------");
            Console.WriteLine($"Area={sum}");
            Console.ReadLine();
        }
    }
}
