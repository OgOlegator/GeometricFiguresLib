namespace GeometricFiguresLib.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(2, 5, 10, 0)]  // 0 - т.к. такого треугольника не существует
        [DataRow(3, 4, 5, 6)]
        [DataRow(6, 8, 10, 24)]
        [DataRow(11, 0, 10, 0)]
        [DataRow(-4, 5, 6, 0)]
        public void GetSquareTriangle_TriangleSquareCalc_success(double sideA, double sideB, double sideC, double expected)
        {
            var result = GeometricFiguresLib.GetSquareTriangle(sideA, sideB, sideC);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(3, 28.274333882308138)]
        [DataRow(5.2, 84.94866535306801)]
        [DataRow(0, 0)]
        [DataRow(-5, 0)]
        public void GetSquareCircle_CircleSquareCalc_success(double radius, double expected)
        {
            var result = GeometricFiguresLib.GetSquareCircle(radius);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(3, 4, 5, true)]
        [DataRow(2, 9, 10, false)]
        [DataRow(6, 8, 10, true)]
        [DataRow(2, 5, 10, false)]
        [DataRow(1, 1, 1, false)]
        [DataRow(11, 0, 10, false)]
        [DataRow(-4, 5, 6, false)]
        public void IsRightTriangle_CheckTriangleIsRight_success(double sideA, double sideB, double sideC, bool expected)
        {
            var result = GeometricFiguresLib.IsRightTriangle(sideA, sideB, sideC);

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        [DataRow(3, 4, 5, true)]
        [DataRow(2, 9, 10, true)]
        [DataRow(6, 8, 10, true)]
        [DataRow(2, 5, 10, false)]
        [DataRow(1, 1, 1, true)]
        [DataRow(11, 0, 10, false)]
        [DataRow(-4, 5, 6, false)]
        public void IsTriangleExists_CheckTriangleExists_success(double sideA, double sideB, double sideC, bool expected)
        {
            var result = GeometricFiguresLib.IsTriangleExists(sideA, sideB, sideC);

            Assert.AreEqual(expected, result);
        }
    }
}