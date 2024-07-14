using GeometricFiguresLib.Supports;

namespace GeometricFiguresLib.Tests.Supports
{
    [TestClass]
    public class FigureParametersTest
    {
        [TestMethod]
        [DataRow(new double[] { 6, 8, 10 })]
        public void AddSides_AddToDictionary_success(double[] sides)
        {
            var sidesList = sides.ToList();
            var parameters = new FigureParameters();

            parameters.AddSides(sidesList).GetParams().TryGetValue(FigureParameters.SidesKey, out var result);

            Assert.IsNotNull(result);
            Assert.IsTrue(result == sidesList);

            //Должна произойти перезапись параметров в словаре
            parameters.AddSides(sidesList).GetParams().TryGetValue(FigureParameters.SidesKey, out var result2);

            Assert.IsNotNull(result2);
            Assert.IsTrue(result2 == sidesList);
        }

        [TestMethod]
        [DataRow(new double[] { 123 })]
        public void AddAngles_AddToDictionary_success(double[] angles)
        {
            var anglesList = angles.ToList();
            var parameters = new FigureParameters();

            parameters.AddAngles(anglesList).GetParams().TryGetValue(FigureParameters.AnglesKey, out var result);

            Assert.IsNotNull(result);
            Assert.IsTrue(result == anglesList);

            //Должна произойти перезапись параметров в словаре
            parameters.AddAngles(anglesList).GetParams().TryGetValue(FigureParameters.AnglesKey, out var result2);

            Assert.IsNotNull(result2);
            Assert.IsTrue(result2 == anglesList);
        }
    }
}
