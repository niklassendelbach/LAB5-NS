using System;
namespace LAB5_NS
{
    public class Triangle : IGetArea
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public Triangle(double bas, double height)
        {
            this.Base = bas;
            this.Height = height;
        }
        public double GetArea() // Calculates area of a triangle
        {
            double area = (Base * Height) / 2;
            Console.Write($"Arean av en triangel med bas {Base} och höjd {Height} är: ");
            Console.WriteLine(Math.Round(area, 2));
            return area;
        }
    }
}
