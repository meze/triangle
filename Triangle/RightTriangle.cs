using System;
using System.Linq;

namespace CompanyLib
{
    static public class RightTriangle
    {
        static public double Area(double sideA, double sideB, double sideC)
        {
            var sides = new [] { sideA, sideB, sideC };
            var hypotenuse = sides.Max();
            var cathetus = sides.Where(x => x < hypotenuse);

            var epsilon = 0.001;
            if (hypotenuse == 0 || Math.Abs(cathetus.Select(x => x * x).Sum() - hypotenuse * hypotenuse) > epsilon)
            {
                throw new ArgumentException("It is not a right triangle");
            }

            return cathetus.Aggregate(1.0, (prod, next) => prod * next) / 2;
        }
    }
}
