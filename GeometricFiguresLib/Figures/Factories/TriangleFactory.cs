namespace GeometricFiguresLib.Figures.Factories
{
    public class TriangleFactory : IFigureFactory
    {
        public bool TryGet(List<double> sides, out IFigure triangle)
        {
            triangle = null;

            if (sides == null || sides.Count() != 3)
                return false;

            triangle = new FigureTriangle(sides[0], sides[1], sides[2]);

            return ((FigureTriangle)triangle).IsExists();
        }
    }
}
