using GeometricFiguresLib.Factories;
using GeometricFiguresLib.Supports;

namespace GeometricFiguresLib.Tests.Factories
{
    [TestClass]
    public class TriangleFactoryTest
    {
        [TestMethod]
        [DataRow(new double[] { 6, 8, 10 }, true)]
        [DataRow(new double[] { 3, 4, 5 }, true)]
        [DataRow(new double[] { 11, 0, 10 }, false)]
        [DataRow(new double[] { -4, 5, 6 }, false)]
        [DataRow(new double[] { 5.2 }, false)]
        [DataRow(new double[] { 3 }, false)]
        [DataRow(new double[] { -5 }, false)]
        [DataRow(new double[] { 0 }, false)]
        [DataRow(new double[] { 41, 25, 41, 25 }, false)]
        [DataRow(new double[] { 4, 4, 4, 4 }, false)]
        public void TryGet_CreateInstance_success(double[] sides, bool expected)
        {
            var parameters = new FigureParameters().AddSides(sides.ToList());

            var result = new TriangleFactory().TryGet(parameters, out _);

            Assert.AreEqual(expected, result);
        }
    }
}
