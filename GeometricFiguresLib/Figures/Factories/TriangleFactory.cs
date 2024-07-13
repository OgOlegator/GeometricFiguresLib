using GeometricFiguresLib.Exceptions;
using GeometricFiguresLib.Figures.Supports;

namespace GeometricFiguresLib.Figures.Factories
{
    /// <summary>
    /// Фабрика для получения объекта треугольника 
    /// </summary>
    public class TriangleFactory : IFigureFactory
    {
        public bool TryGet(FigureParameters parameters, out IFigure triangle)
        {
            triangle = null;

            if (parameters == null)
                return false;

            if (!parameters.GetParams().TryGetValue(FigureParameters.SidesKey, out var sides))
                return false;

            if (sides.Count() != 3)
                return false;

            try
            {
                triangle = new Triangle(sides[0], sides[1], sides[2]);

                return true;
            }
            catch (FigureNotExistsException)
            {
                return false;
            }
        }
    }
}
