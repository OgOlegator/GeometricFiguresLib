using GeometricFiguresLib.Exceptions;
using GeometricFiguresLib.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresLib.Tests.Figures
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        [DataRow(3, 28.274333882308138)]
        [DataRow(5.2, 84.94866535306801)]
        public void GetSquare_SquareCalc_success(double radius, double expected)
        {
            IFigure figure = new Circle(radius);

            var result = figure.GetSquare();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(3, true)]
        [DataRow(5.2, true)]
        public void IsExists_CheckExists_success(double radius, bool expected)
        {
            var result = new Circle(radius).IsExists();

            Assert.IsTrue(result);
        }

        [TestMethod]
        [DataRow(0)]
        [DataRow(-5)]
        public void Constructor_FigureNotExists_exception(double radius)
        {
            Assert.ThrowsException<FigureNotExistsException>(() => new Circle(radius));
        }
    }
}
