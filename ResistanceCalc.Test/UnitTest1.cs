using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResistanceCalc.Models;

namespace ResistanceCalc.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestResistanceCalculator1()
        {
            ICalculateResistance calc = new ResistanceCalculator();
            string result = calc.CalculateResistance("Red", "Red", "Blue", "None");
            Assert.IsTrue(result == "22000000Ω ±20%");
        }
    }
}
