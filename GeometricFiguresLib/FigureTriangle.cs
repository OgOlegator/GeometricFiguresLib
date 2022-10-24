using static System.Math;

namespace GeometricFiguresLib
{
    public class FigureTriangle : IFigure
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public FigureTriangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public double GetSquare()
        {
            if (!IsTriangleExists())
                return 0;

            var semiPerimeter = (_sideA + _sideB + _sideC) / 2;

            return Sqrt(semiPerimeter * (semiPerimeter - _sideA) * (semiPerimeter - _sideB) * (semiPerimeter - _sideC));
        }

        public bool IsTriangleExists()
            => !(_sideA + _sideB < _sideC
                || _sideA + _sideC < _sideB
                || _sideB + _sideC < _sideA);

        public bool IsRightTriangle()
            => Pow(_sideA, 2) + Pow(_sideB, 2) == Pow(_sideC, 2)
            || Pow(_sideA, 2) + Pow(_sideC, 2) == Pow(_sideB, 2)
            || Pow(_sideB, 2) + Pow(_sideC, 2) == Pow(_sideA, 2);
    }
}
