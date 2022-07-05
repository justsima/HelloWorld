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
            Circle cr = new Circle();
            Console.WriteLine("Enter radius: ");
            int rad = Console.Read();
            Console.WriteLine("Area of Circle: ");
            Console.WriteLine("Enter length: ");
            Console.WriteLine("Enter height: ");
            Console.WriteLine("Area of rectangle");
            Console.WriteLine("Perimeter  of rectangle");
          
        }
    }
}
