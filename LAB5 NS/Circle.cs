using System;

namespace LAB5_NS
{
    public class Circle : IGetArea
    {
        public double Radius { get; set; }
        public Circle(double radius) 
        {
            this.Radius = radius;
        }
        public double GetArea() // Calculates area of a circle
        {
            double area = Radius * Radius * Math.PI;
            Console.Write($"Arean av en cirkel med radie {Radius} är: ");
            Console.WriteLine(Math.Round(area, 2));
            return area;
        }
        public double GetVolume() // Calculates volume of a globe
        {
            double volume = (4 * Math.PI * Math.Pow(Radius, 3) / 3);
            Console.Write($"Volymen av bollen med {Radius} i radie är: ");
            Console.WriteLine(Math.Round(volume, 2));
            return volume;
        }
    }
}
