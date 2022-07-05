using System;
namespace ConsoleApp2
{
    abstract class shape
    {
        public abstract double calcArea();
        public abstract double calcPermiter();
    }
    class Circle : shape
    {
        public double radius { get; set; }
        static readonly double PI = 3.14;
        public override double calcArea()
        {
            return PI * radius * radius;
        }
        public override double calcPermiter()
        {
            return 2 * PI * radius;
        }

    }
    class Rectangle : shape
    {
        public double height { get; set; }
        public double length { get; set; }
        public override double calcArea()
        {
            return height * length;
        }
        public override double calcPermiter()
        {
            return 2 * (length * height);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle();
            Rectangle r = new Rectangle();
            Console.WriteLine("Enter the radius ");
            c.radius = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of the circle is " + c.calcArea());
            Console.WriteLine("Circumfrence of the circle is " + c.calcPermiter());
            Console.WriteLine("Enter the Length ");
            r.length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height ");
            r.height = double.Parse(Console.ReadLine());
            Console.WriteLine("Area of the Rectangle is " + r.calcArea());
            Console.WriteLine("Perimeter of the Rectangle is " + r.calcPermiter());
        }
    }
}
    
