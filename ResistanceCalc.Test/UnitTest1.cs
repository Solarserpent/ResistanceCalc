using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResistanceCalc.Models;

namespace ResistanceCalc.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestResistanceCalculatorInputs()
        {
            IOhmValueCalculator calc = new ResistanceCalculator();
            string result = null;
            foreach (var colorA in ResistanceCalculator.ResistanceValueMap)
                foreach (var colorB in ResistanceCalculator.ResistanceValueMap)
                    foreach (var colorC in ResistanceCalculator.ResistanceMagnitudeMap)
                        foreach (var colorD in ResistanceCalculator.ResistanceToleranceMap)
                        {
                            result = calc.CalculateResistance(colorA.Key, colorB.Key, colorC.Key, colorD.Key);
                            Assert.IsFalse(result == null);
                        }
        }

        [TestMethod]
        public void TestResistanceCalculatorOutput()
        {
            IOhmValueCalculator calc = new ResistanceCalculator();

            foreach (var colorA in ResistanceCalculator.ResistanceValueMap)
                foreach (var colorB in ResistanceCalculator.ResistanceValueMap)
                    foreach (var colorC in ResistanceCalculator.ResistanceMagnitudeMap)
                        foreach (var colorD in ResistanceCalculator.ResistanceToleranceMap)
                        {
                            string result = calc.CalculateResistance(colorA.Key, colorB.Key, colorC.Key, colorD.Key);
                            decimal value = (ResistanceCalculator.ResistanceValueMap[colorA.Key] * 10 + ResistanceCalculator.ResistanceValueMap[colorB.Key]) * ResistanceCalculator.ResistanceMagnitudeMap[colorC.Key];
                            string expectedResult = $"{value}Ω ±{ResistanceCalculator.ResistanceToleranceMap[colorD.Key]}%";
                            Assert.AreEqual(expectedResult, result);
                        }
        }

        [TestMethod]
        public void TestResistanceCalculatorSpotCheck()
        {
            IOhmValueCalculator calc = new ResistanceCalculator();
            var result = calc.CalculateResistance("Red", "Red", "Blue", "None");
            Assert.AreEqual(result, "22000000Ω ±20%");
            result = calc.CalculateResistance("Black", "Gray", "Orange", "Brown");
            Assert.AreEqual(result, "8000Ω ±1%");
            result = calc.CalculateResistance("Violet", "White", "Yellow", "Gold");
            Assert.AreEqual(result, "790000Ω ±5%");
        }
    }
}
