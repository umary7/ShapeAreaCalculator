using System;

namespace ShapeAreaCalculator
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(double radius)
        {
            if (radius < 0)
            {
                throw new Exception("Radius value must be a positive number.");
            }

            _radius = radius;
        }

        public override double Area => CalcArea();

        private double CalcArea()
        {
            return Math.Round(Math.PI * Math.Pow(_radius, 2), 2);
        }
    }
}