using System;
using System.Collections.Generic;
using System.Linq;

namespace ShapeAreaCalculator
{
    public class Triangle : Shape
    {
        private double _sideA;
        private double _sideB;
        private double _sideC;

        public Triangle(double a, double b, double c)
        {
            if (a < 0 || b < 0 || c < 0)
            {
                throw new Exception("Value must be a positive number.");
            }

            if (!ValidTriangle(a, b, c))
            {
                throw new Exception("Side lengths do not adhere to the triangle inequality theorem.");
            }

            _sideA = a;
            _sideB = b;
            _sideC = c;
        }

        private static bool ValidTriangle(double sideA, double sideB, double sideC)
        {
            return !(sideA > sideB + sideC) && !(sideB > sideA + sideC) && !(sideC > sideA + sideB);
        }

        public bool RightAngled
        {
            get
            {
                var hypotenuse = Math.Max(_sideA, Math.Max(_sideB, _sideC));
                var sides = new List<double>() {_sideA, _sideB, _sideC};
                sides.Remove(hypotenuse);
                for (int i = 0; i < sides.Count; i++)
                {
                    sides[i] = Math.Pow(sides[i], 2);
                }

                return Math.Pow(hypotenuse, 2) == sides.Sum();
            }
        }

        public override double Area => CalcArea();

        private double CalcArea()
        {
            var p = (_sideA + _sideB + _sideC) / 2;
            var area = Math.Sqrt(p * (p - _sideA) * (p - _sideB) * (p - _sideC));
            return Math.Round(area, 2);
        }
    }

}