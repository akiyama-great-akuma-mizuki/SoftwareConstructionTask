using System;
using System.Collections;
using System.Collections.Generic;
namespace Task2
{
    class Program

    {
        static void Main(string[] args)
        {
            String[] ShapeNames = new String[] { "CIRCLE", "RECTANGLE", "TRIANGLE" };
            Random rdm = new Random();
            double sumOfArea = 0;
            for (int i = 0; i < 10; i++)
            {
                int idx = rdm.Next(0, 3);
                Shape newShape = new Factory().GetShape(ShapeNames[idx]);
                if (newShape != null)
                    sumOfArea += newShape.GetArea();
                Console.WriteLine("生成了一个" + ShapeNames[idx]);
            }
            Console.WriteLine("其面积之和是:" + sumOfArea);
        }

    }
    interface Shape
    {
        double GetArea();
    }
    class Circle : Shape
    {
        private double radius = 5;
        public Circle(double r)
        {
            radius = r;
        }
        public Circle() { }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
    class Rectangle : Shape
    {
        private double width = 2;
        private double lenGth = 5;
        public Rectangle(double w, double l)
        {
            width = w;
            lenGth = l;
        }
        public Rectangle() { }
        public double GetArea()
        {
            return width * lenGth;
        }
    }
    class Triangle : Shape
    {
        private double l1 = 6, l2 = 6, l3 = 6;
        public Triangle(double a1, double a2, double a3)
        {
            l1 = a1;
            l2 = a2;
            l3 = a3;
        }
        public Triangle() { }
        public double GetArea()
        {
            return 0.25 * Math.Sqrt((l1 + l2 + l3) * (l1 + l2 - l3) *
                                    (l1 + l3 - l2) * (l2 + l3 - l1));
        }
    }
    class Factory
    {
        public Shape GetShape(String ShapeType)
        {
            if (String.Equals(ShapeType, "CIRCLE",
                    StringComparison.InvariantCultureIgnoreCase))
                return new Circle();
            else if (String.Equals(ShapeType, "RECTANGLE",
                    StringComparison.InvariantCultureIgnoreCase))
                return new Rectangle();
            else if (String.Equals(ShapeType, "TRIANGLE",
                    StringComparison.InvariantCultureIgnoreCase))
                return new Triangle();
            else return null;
        }
    }
}
