using System;
using ShapeAreaCalculator;
using Xunit;

namespace TestShapeAreaCalculator
{
    public class Tests
    {
        [Fact]
        public void TestCircleArea()
        {
            Shape circle = new Circle(3);
            Assert.Equal(28.27, circle.Area);
            Assert.Equal(3.14, new Circle(1).Area);
        }

        [Fact]
        public void TestNonPositiveRadius()
        {
            Assert.Throws<Exception>(() => new Circle(-1));
        }
        
        [Fact]
        public void TestTriangleArea()
        {
            Shape triangle = new Triangle(3, 4, 5);
            Assert.Equal(6, triangle.Area);
            Assert.Equal(3.8, new Triangle(2, 4, 5).Area);
        }

        [Fact]
        public void TestNonPositiveTriangleSide()
        {
            Assert.Throws<Exception>(() => new Triangle(1, 1, -1));
        }

        [Fact]
        public void TestNotValidTriangleSides()
        {
            Assert.Throws<Exception>(() => new Triangle(1, 1, 3));
            Assert.Throws<Exception>(() => new Triangle(5, 1, 2));
        }
    }

}