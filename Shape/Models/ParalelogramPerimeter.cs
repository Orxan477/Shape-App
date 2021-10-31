using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class ParalelogramPerimeter:Paralelogram
    {
        public override void GetPerimeter()
        {
            Console.WriteLine("Enter the sides:");
            Console.Write("Side1= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side2= ");
            Side2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side3= ");
            Side3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Side4= ");
            Side4 = Convert.ToDouble(Console.ReadLine());
            sum = Side1 + Side2 + Side3 + Side4;
            Console.WriteLine("---------------------");
            Console.WriteLine($"Perimeter={sum}");
          //  Console.ReadLine();
        }
    }
}
