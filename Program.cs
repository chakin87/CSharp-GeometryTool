using System;

namespace Geometry_Tool
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var square = new Square() { Width = 2 };
            var triangle = new Triangle() { Base = 2, Height = 5 };

            square.Display();
            triangle.Display();

            Console.ReadLine();
        }
    }

    abstract class Shape
    {
        public abstract int GetArea();

        public void Display()
        {
            Console.WriteLine("The are is {0}", GetArea());
        }
    }

    class Square : Shape
    {
        public int Width;

        public override int GetArea()
        {
            return Width *= Width;
        }
    }

    class Triangle : Shape
    {
        public int Height;
        public int Base;

        public override int GetArea()
        {
            return (Base * Height) /2;
        }
    }
}
