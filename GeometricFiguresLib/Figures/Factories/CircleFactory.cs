namespace GeometricFiguresLib.Figures.Factories
{
    public class CircleFactory : IFigureFactory
    {
        public bool TryGet(List<double> sides, out IFigure circle)
        {
            circle = null;

            if (sides == null || sides.Count() != 1)
                return false;

            var radius = sides[0];

            circle = new FigureCircle(radius);

            return true;
        }
    }
}
