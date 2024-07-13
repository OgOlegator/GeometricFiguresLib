using GeometricFiguresLib.Exceptions;
using GeometricFiguresLib.Figures;

namespace GeometricFiguresLib.Tests.Figures
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [DataRow(3, 4, 5, 6)]
        [DataRow(6, 8, 10, 24)]
        public void GetSquare_SquareCalc_success(double sideA, double sideB, double sideC, double expected)
        {
            var figure = new Triangle(sideA, sideB, sideC);

            var result = figure.GetSquare();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(3, 4, 5, true)]
        [DataRow(2, 9, 10, false)]
        [DataRow(6, 8, 10, true)]
        [DataRow(1, 1, 1, false)]
        public void IsRight_CheckIsRight_success(double sideA, double sideB, double sideC, bool expected)
        {
            var result = new Triangle(sideA, sideB, sideC).IsRight();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(3, 4, 5)]
        [DataRow(2, 9, 10)]
        [DataRow(6, 8, 10)]
        [DataRow(1, 1, 1)]
        public void IsExists_CheckExists_success(double sideA, double sideB, double sideC)
        {
            var result = new Triangle(sideA, sideB, sideC).IsExists();

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(2, 5, 10)]
        [DataRow(11, 0, 10)]
        [DataRow(-4, 5, 6)]
        public void Constructor_FigureNotExists_exception(double sideA, double sideB, double sideC)
        {
            Assert.ThrowsException<FigureNotExistsException>(() => new Triangle(sideA, sideB, sideC));
        }
    }
}