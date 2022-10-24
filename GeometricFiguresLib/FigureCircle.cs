using static System.Math;

namespace GeometricFiguresLib
{
    public class FigureCircle : IFigure
    {
        private readonly double _radius;

        public FigureCircle(double radius)
        {
            _radius = radius;
        }

        public double GetSquare()
        {
            return _radius > 0 ? Pow(_radius, 2) * PI : 0;
        }
    }
}
