using System;
using CompanyLib;
using Xunit;

namespace Company.Tests
{
    public class RightTriangleTest
    {
        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(1, 2, 3)]
        [InlineData(0, 2, 3)]
        [InlineData(-3, -3, -3)]
        [InlineData(10, 15, 40)]
        [InlineData(40, 15, 10)]
        [InlineData(15, 40, 10)]
        public void FailsIfTriangleDoesNotExist(double a, double b, double c)
        {
            Action code = () => RightTriangle.Area(a, b, c);

            var exception = Assert.Throws<ArgumentException>(code);

            Assert.Contains("not a right triangle", exception.Message);
        }

        [Theory]
        [InlineData(70, 20, 60)]
        [InlineData(3, 5, 5)]
        public void FailsIfTriangleIsNotRight(double a, double b, double c)
        {
            Action code = () => RightTriangle.Area(a, b, c);

            var exception = Assert.Throws<ArgumentException>(code);

            Assert.Contains("not a right triangle", exception.Message);
        }

        [Theory]
        [InlineData(3, 7, 7.6158, 10.5)]
        [InlineData(6.3246, 2, 6, 6)]
        [InlineData(3, 5, 4, 6)]
        public void CalculatesAreaOfTriangle(double a, double b, double c, double area)
        {
            Assert.Equal(area, RightTriangle.Area(a, b, c));
        }
    }
}
