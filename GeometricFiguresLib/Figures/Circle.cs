using GeometricFiguresLib.Exceptions;
using static System.Math;

namespace GeometricFiguresLib.Figures
{
    /// <summary>
    /// 
    /// </summary>
    public class Circle : IFigure
    {
        private readonly double _radius;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <exception cref="FigureNotExistsException">Ошибка</exception>
        public Circle(double radius)
        {
            _radius = radius;

            if (!IsExists())
                throw new FigureNotExistsException();
        }

        public double GetSquare()
            => Pow(_radius, 2) * PI;

        public bool IsExists()
            => _radius > 0;
    }
}
