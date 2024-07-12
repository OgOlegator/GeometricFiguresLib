using GeometricFiguresLib.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFiguresLib.Tests
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
            var result = UnknownFigureHandler.GetSquare(sides.ToList());

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(new double[] { 6, 8, 10 }, typeof(FigureTriangle))]
        [DataRow(new double[] { 3, 4, 5 }, typeof(FigureTriangle))]
        [DataRow(new double[] { 5.2 }, typeof(FigureCircle))]
        [DataRow(new double[] { 3 }, typeof(FigureCircle))]
        public void GetFigure_DefinitionFigure_success(double[] sides, Type type)
        {
            var result = UnknownFigureHandler.GetFigure(sides.ToList()).GetType();

            Assert.IsTrue(result == type);
        }
    }
}
