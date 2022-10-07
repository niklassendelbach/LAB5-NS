using System;
namespace LAB5_NS
{
    class Program
    {
        static void Main(string[] args)
        {

            // NIKLAS SENDELBACH NET22

            Circle C1 = new Circle(5);
            C1.GetArea();
            Circle C2 = new Circle(6);
            C2.GetArea();
            Circle C3 = new Circle(13);
            C3.GetVolume();
            Triangle T1 = new Triangle(5, 5);
            T1.GetArea();
            Triangle T2 = new Triangle(10, 5);
            T2.GetArea();
        }
    }
}
