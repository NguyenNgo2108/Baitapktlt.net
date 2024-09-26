using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiKiemTra2
{
    public interface IShape
    {
        double CalculateArea();
    }

    public class Circle : IShape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double CalculateArea()
        {
            return Width * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle(5);
            IShape rectangle = new Rectangle(10, 20);

            Console.WriteLine($"Dien tich hinh tron la: {circle.CalculateArea():F2}");
            Console.WriteLine($"Dien tich hinh chu nhat la: {rectangle.CalculateArea():F2}");
        }
    }
}
