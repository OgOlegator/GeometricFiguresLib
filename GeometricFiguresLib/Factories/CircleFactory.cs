using GeometricFiguresLib.Exceptions;
using GeometricFiguresLib.Figures;
using GeometricFiguresLib.Supports;

namespace GeometricFiguresLib.Factories
{
    /// <summary>
    /// Фабрика для получения объекта круга 
    /// </summary>
    public class CircleFactory : IFigureFactory
    {
        public bool TryGet(FigureParameters parameters, out IFigure circle)
        {
            circle = null;

            if (parameters == null)
                return false;

            if (!parameters.GetParams().TryGetValue(FigureParameters.SidesKey, out var sides))
                return false;

            if (sides.Count() != 1)
                return false;

            try
            {
                circle = new Circle(sides[0]);

                return true;
            }
            catch (FigureNotExistsException)
            {
                return false;
            }
        }
    }
}
