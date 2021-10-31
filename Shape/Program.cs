using System;
using Shape.Models;
namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Trapezoid tra1 = new Trapezoid();
            tra1.GetPerimeter();
            //Console.WriteLine("Welcome");
            //Console.WriteLine($"1.Square\n2.Rectongle\n3.Circle\n4.Traperoid\n5.Palelogram\n6.Tringle\n7.Pentogen\n8.Hexogen\n");
            //Console.WriteLine("Select the figure to be calculated.");
            //string figinput = Console.ReadLine();
            //int figure = int.Parse(figinput);
            //Console.WriteLine("-------------------------");
            //if (figure == 1)
            //{
            //TryAgain:
            //    Console.WriteLine("1.Perimeter or 2.Area?");
            //    Console.WriteLine("Please enter a number.");
            //    try
            //    {
            //        string opinput = Console.ReadLine();
            //        int option = int.Parse(opinput);
            //        if (option == 1)
            //        {
            //            Square square1 = new Square();
            //            square1.GetPerimeter();
            //        }
            //        else if (option == 2)
            //        {
            //            Square square2 = new Square();
            //            square2.GetArea();
            //        }

            //    }
            //    catch (Exception)
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Enter a number!!!");
            //        goto TryAgain;
            //    }





        }
    }
}
