using static System.Math;

namespace GeometricFiguresLib
{
    public partial class GeometricFiguresLib
    {

        public static bool IsTriangleExists(double sideA, double sideB, double sideC)
            => !(sideA + sideB < sideC
                || sideA + sideC < sideB
                || sideB + sideC < sideA);

        public static bool IsRightTriangle(double sideA, double sideB, double sideC)
            => Pow(sideA, 2) + Pow(sideB, 2) == Pow(sideC, 2)
            || Pow(sideA, 2) + Pow(sideC, 2) == Pow(sideB, 2)
            || Pow(sideB, 2) + Pow(sideC, 2) == Pow(sideA, 2);

    }
}
