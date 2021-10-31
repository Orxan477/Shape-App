using System;
using Shape.Models;
namespace Shape
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome.");
        TryAgain:
            Console.WriteLine("1.Perimeter or 2.Area?");
            Console.WriteLine("Please enter a number.");
            try
            {
                string opinput = Console.ReadLine();
                int option = int.Parse(opinput);
                Console.WriteLine("---------------");
                if (option == 1)
                {
                Start:
                    Console.WriteLine($"1.Square\n2.Rectongle\n3.Circle\n4.Traperoid\n5.Palelogram\n6.Tringle\n7.Pentogen\n8.Hexogen\n");
                    try
                    {
                        Console.WriteLine("Select the figure to be calculated.");
                        string figinput = Console.ReadLine();
                        int figure = int.Parse(figinput);
                        Console.WriteLine("-------------------------");
                        if (figure == 1)
                        {
                            SquarePerimeter squ1 = new SquarePerimeter();
                            squ1.GetPerimeter();
                        }
                        else if (figure == 2)
                        {
                            RectanglePerimeter rec1 = new RectanglePerimeter();
                            rec1.GetPerimeter();
                        }
                        else if (figure == 3)
                        {
                            CirclePerimeter cir1 = new CirclePerimeter();
                            cir1.GetPerimeter();
                        }
                        else if (figure == 4)
                        {
                            TrapezoidPerimeter tra1 = new TrapezoidPerimeter();
                            tra1.GetPerimeter();
                        }
                        else if (figure == 5)
                        {
                            ParalelogramPerimeter para1 = new ParalelogramPerimeter();
                            para1.GetPerimeter();
                        }
                        else if (figure == 6)
                        {
                            TrianglePerimeter tri1 = new TrianglePerimeter();
                            tri1.GetPerimeter();
                        }
                        else if (figure == 7)
                        {
                            PentagonPerimeter pe1 = new PentagonPerimeter();
                            pe1.GetPerimeter();
                        }
                        else if (figure == 8)
                        {
                            HexogenPerimeter he1 = new HexogenPerimeter();
                            he1.GetPerimeter();
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Enter a correct number!!!");
                            Console.WriteLine("-----------------------");
                            goto Start;
                        }

                    }
                    catch (Exception)
                    {
                        Console.Clear();
                        Console.WriteLine("Please Enter a number!!!");
                        Console.WriteLine("-----------------------");
                        goto Start;
                    }
                }
                else if (option == 2)
                {
                Second:
                    Console.WriteLine($"1.Square\n2.Rectongle\n3.Circle\n4.Traperoid\n5.Palelogram\n----Tringle:\n  6.Equilateral Triangle\n  7.Various Triangle\n  8.IsoscelesTriangle\n  9.Right Triangle\n10.Pentogen\n11.Hexogen");
                    try
                    {

                        Console.WriteLine("Select the figure to be calculated.");
                        string figinput = Console.ReadLine();
                        int figure = int.Parse(figinput);
                        Console.WriteLine("-------------------------");
                        if (figure == 1)
                        {
                            SquareArea squ1 = new SquareArea();
                            squ1.GetArea();
                        }
                        else if (figure == 2)
                        {
                            RectangleArea rec1 = new RectangleArea();
                            rec1.GetArea();
                        }
                        else if (figure == 3)
                        {
                            CircleArea cir1 = new CircleArea();
                            cir1.GetArea();
                        }
                        else if (figure == 4)
                        {
                            TrapezoidArea tra1 = new TrapezoidArea();
                            tra1.GetArea();
                        }
                        else if (figure == 5)
                        {
                            ParalelogramArea para1 = new ParalelogramArea();
                            para1.GetArea();
                        }
                        else if (figure == 6)
                        {
                            EquilateralTriangle equ1 = new EquilateralTriangle();
                            equ1.GetArea();
                        }
                        else if (figure == 7)
                        {
                            VariousTriangles var1 = new VariousTriangles();
                            var1.GetArea();
                        }
                        else if (figure == 8)
                        {
                            IsoscelesTriangles iso1 = new IsoscelesTriangles();
                            iso1.GetArea();
                        }
                        else if (figure == 9)
                        {
                            RightTriangle rig1 = new RightTriangle();
                            rig1.GetArea();
                        }
                        else if (figure == 10)
                        {
                            PentagonArea pen1 = new PentagonArea();
                            pen1.GetArea();
                        }
                        else if (figure == 11)
                        {
                            HexogenArea he1 = new HexogenArea();
                            he1.GetArea();
                        }

                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Enter a correct number!!!");
                            Console.WriteLine("-----------------------");
                            goto Second;
                        }
                    }
                    catch (Exception)
                    {

                        Console.Clear();
                        Console.WriteLine("Enter a number!!!");
                        Console.WriteLine("-----------------------");
                        goto Second;
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Enter a number!!!");
                    Console.WriteLine("-----------------------");
                    goto TryAgain;
                }
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Enter a number!!!");
                Console.WriteLine("-----------------------");
                goto TryAgain;
            }
        }
    }
}