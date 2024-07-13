using GeometricFiguresLib.Figures.Factories;
using GeometricFiguresLib.Figures.Supports;

namespace GeometricFiguresLib.Tests.Factories
{
    [TestClass]
    public class CircleFactoryTest
    {
        [TestMethod]
        [DataRow(new double[] { 6, 8, 10 }, false)]
        [DataRow(new double[] { 5.2 }, true)]
        [DataRow(new double[] { 3 }, true)]
        [DataRow(new double[] { -5 }, false)]
        [DataRow(new double[] { 0 }, false)]
        [DataRow(new double[] { 41, 25, 41, 25 }, false)]
        [DataRow(new double[] { 4, 4, 4, 4 }, false)]
        public void TryGet_CreateInstance_success(double[] sides, bool expected)
        {
            var parameters = new FigureParameters().AddSides(sides.ToList());
            var result = new CircleFactory().TryGet(parameters, out _);

            Assert.AreEqual(expected, result);
        }
    }
}
