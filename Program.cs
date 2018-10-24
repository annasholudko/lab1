using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What figure do you want to create?");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Circle");
            Console.WriteLine("3. Rhombus");
            char answer;
            do
            {
                int a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            Creator dev = new SquareCreator();
                            Figure fig1 = dev.Create();
                            break;
                        }
                    case 2:
                        {
                            Creator dev2 = new CircleCreator();
                            Figure fig2 = dev2.Create();
                            break;
                        }

                    case 3:
                        {
                            Creator dev3 = new RhombusCreator();
                            Figure fig3 = dev3.Create();
                            break;
                        }
                }
                Console.WriteLine("Create other figure (y/n)");
                answer = char.Parse(Console.ReadLine());
            } while (answer != 'n');
            Console.ReadLine();
        }
    }

    abstract class Creator
    {

        public Creator()
        { }
        abstract public Figure Create();
    }

    class SquareCreator : Creator
    {
        public SquareCreator()
        { }

        public override Figure Create()
        {
            return new Square(3, "black", 9);
        }

    }

    class CircleCreator : Creator
    {
        public CircleCreator()
        { }

        public override Figure Create()
        {
            return new Circle(4, "white", 50.265);
        }
    }
    class RhombusCreator : Creator
    {
        public RhombusCreator()
        { }

        public override Figure Create()
        {
            return new Rhombus(5, "green", 100);
        }
    }

    abstract class Figure
    {
        public double Side1 { get; set; }
        public string Colour { get; set; }
        public double Square { get; set; }
        public Figure(double n, string c, double s)
        {
            Side1 = n;
            Colour = c;
            Square = s;
        }
    }

    class Square : Figure
    {
        double side = 0, square = 0;
        string colour;
        public Square(double n, string c, double s)
            : base(n, c, s)
        {
            side = n;
            colour = c;
            square = s;
            Console.WriteLine("Square is created side= " + n + " colour= " + c + " square " + s);
        }
    }
    class Circle : Figure
    {
        double radius = 0, square = 0;
        string colour;
        public Circle(double n, string c, double s)
            : base(n, c, s)
        {
            radius = n;
            colour = c;
            square = s;
            Console.WriteLine("Circle is created radius= " + n + " colour= " + c + " square " + s);
        }
    }
    class Rhombus : Figure
    {
        double side = 0, square = 0;
        string colour;
        public Rhombus(double n, string c, double s)
            : base(n, c, s)
        {
            side = n;
            colour = c;
            square = s;
            Console.WriteLine("Rhombus is created side= " + n + " colour= " + c + " square " + s);
        }
    }
}
