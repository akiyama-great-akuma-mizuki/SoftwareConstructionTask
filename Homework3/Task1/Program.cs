using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSHomeWork3
{
    interface Shape
    {
        bool IsVaild();
        double GetArea();
    }
    class Rectangle : Shape
    {
        private double width;
        private double length;
        public Rectangle(double w, double l)
        {
            width = w;
            length = l;
        }
        public bool IsVaild()
        {
            return width > 0 && length > 0;
        }
        public double GetArea()
        {
            return width * length;
        }
        public double Width { get => width; set => width = value; }
        public double Length { get => length; set => length = value; }
    }
    class Square : Shape
    {
        private double side;
        public Square(double length)
        {
            side = length;
        }
        public bool IsVaild()
        {
            return side > 0;
        }
        public double GetArea()
        {
            return side * side;
        }
        public double Side
        {
            get => side;
            set => side = value;
        }
    }
    class Circle : Shape
    {
        private double radius;
        public Circle(double r)
        {
            radius = r;
        }
        public bool IsVaild()
        {
            return radius > 0;
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
        public double Radius
        {
            get => radius;
            set => radius = value;
        }
    }
    class Triangle : Shape
    {
        private double s1, s2, s3;
        public Triangle(double side1, double side2, double side3)
        {
            s1 = side1; s2 = side2; s3 = side3;
        }
        public bool IsVaild()
        {
            return s1 > 0 && s2 > 0 && s3 > 0 &&
                    s1 + s2 > s3 && s1 + s3 > s2 && s2 + s3 > s1;
        }
        public double GetArea()
        {
            return 0.25 * Math.Sqrt((s1 + s2 + s3) * (s1 + s2 - s3) *
                                    (s1 + s3 - s2) * (s2 + s3 - s1));
        }
        public double S1 { get => s1; set => s1 = value; }
        public double S2 { get => s2; set => s2 = value; }
        public double S3 { get => s3; set => s3 = value; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("输入长方形的长:");
                double l = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("输入长方形的宽:");
                double w = Convert.ToDouble(Console.ReadLine());
                Shape S1 = new Rectangle(l, w);
                Console.WriteLine(S1.IsVaild() ? $"形状合法，面积是{S1.GetArea()}" : "不合法");
                Console.WriteLine("输入正方形边长:");
                l = Convert.ToDouble(Console.ReadLine());
                Shape S2 = new Square(l);
                Console.WriteLine(S2.IsVaild() ? $"形状合法，面积是{S2.GetArea()}" : "不合法");
                Console.WriteLine("输入三角形第一条边");
                double l1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("输入三角形第二条边");
                double l2 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("输入三角形第三条边");
                double l3 = Convert.ToDouble(Console.ReadLine());
                Shape S3 = new Triangle(l1, l2, l3);
                Console.WriteLine(S3.IsVaild() ? $"形状合法，面积是{S3.GetArea()}" : "不合法");
                Console.WriteLine("输入圆半径:");
                double r = Convert.ToDouble(Console.ReadLine());
                Shape S4 = new Circle(r);
                Console.WriteLine(S4.IsVaild() ? $"形状合法，面积是{S4.GetArea()}" : "不合法");
            }
            catch (Exception E)
            {
                Console.WriteLine(E.Message);
            }
        }
    }
}
