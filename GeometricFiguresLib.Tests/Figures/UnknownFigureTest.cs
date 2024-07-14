using GeometricFiguresLib.Exceptions;
using GeometricFiguresLib.Figures;
using GeometricFiguresLib.Supports;

namespace GeometricFiguresLib.Tests.Figures
{
    [TestClass]
    public class UnknownFigureTest
    {
        [TestMethod]
        [DataRow(new double[] { 6, 8, 10 }, 24)]
        [DataRow(new double[] { 3, 4, 5 }, 6)]
        [DataRow(new double[] { 5.2 }, 84.94866535306801)]
        [DataRow(new double[] { 3 }, 28.274333882308138)]
        public void GetSquare_SquareCalc_success(double[] sides, double expected)
        {
            var result = GetInstanceBySides(sides).GetSquare();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(new double[] { 6, 8, 10 })]
        [DataRow(new double[] { 3, 4, 5 })]
        [DataRow(new double[] { 5.2 })]
        [DataRow(new double[] { 3 })]
        public void IsExsists_CheckExsists_success(double[] sides)
        {
            var result = GetInstanceBySides(sides).IsExists();

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(new double[] { 11, 0, 10 })]
        [DataRow(new double[] { -4, 5, 6 })]
        [DataRow(new double[] { -5 })]
        [DataRow(new double[] { 0 })]
        [DataRow(new double[] { 41, 25, 41, 25 })]
        [DataRow(new double[] { 4, 4, 4, 4 })]
        public void ConstructorBySides_FigureNotFound_exception(double[] sides)
        {
            Assert.ThrowsException<GeometricFiguresLibException>(() => GetInstanceBySides(sides));
        }

        [TestMethod]
        [DataRow(new double[] { 6, 8, 10 }, typeof(Triangle))]
        [DataRow(new double[] { 3, 4, 5 }, typeof(Triangle))]
        [DataRow(new double[] { 5.2 }, typeof(Circle))]
        [DataRow(new double[] { 3 }, typeof(Circle))]
        public void GetFigure_CheckTypeFigure_success(double[] sides, Type expected)
        {
            var result = GetInstanceBySides(sides).GetFigure().GetType();

            Assert.IsTrue(result == expected);
        }

        [TestMethod]
        public void ConstructorByFigure_SetAndOperationsWithFigure_success()
        {
            var triangle = new Triangle(6, 8, 10);

            var unknown = new UnknownFigure(triangle);

            var figureType = unknown.GetFigure().GetType();
            var checkType = typeof(Triangle);

            Assert.IsTrue(unknown.IsExists());
            Assert.IsTrue(unknown.GetSquare() > 0);
            Assert.IsTrue(figureType == checkType);
        }

        private UnknownFigure GetInstanceBySides(double[] sides)
        {
            return new UnknownFigure(new FigureParameters().AddSides(sides.ToList()));
        }
    }
}
