using System;
using System.Collections.Generic;
using System.Text;

namespace Shape.Models
{
    class PentagonArea:Pentagon
    {
        public override void GetArea()
        {
            Console.WriteLine("Enter the sides:");
            Console.Write("Side= ");
            Side1 = Convert.ToDouble(Console.ReadLine());
            sum = ((Math.Sqrt(5*(5+2*Math.Sqrt(5)))*(Side1*Side1))/4);
            Console.WriteLine($"Area={sum}");
        }
    }
}
