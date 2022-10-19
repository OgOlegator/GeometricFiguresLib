using static System.Math;

namespace GeometricFiguresLib
{
    public static partial class GeometricFiguresLib
    {
        public static double GetSquareTriangle(double sideA, double sideB, double sideC)
        {
            if (!IsTriangleExists(sideA, sideB, sideC))
                return 0;

            var semiPerimeter = (sideA + sideB + sideC) / 2;

            return Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));
        }

        public static double GetSquareCircle(double radius)
            => radius > 0 ? Pow(radius, 2) * PI : 0;
    }
}