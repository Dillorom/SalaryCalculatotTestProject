using Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SalaryCalculatotTestProject
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void AnnualSalaryTest()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();

            //Act
            decimal AnnualSalary = sc.GetAnnualSalary(50);

            //Assert
            Assert.AreEqual(104000, AnnualSalary);

        }

        [TestMethod]
        public void HourlyWageTestt()
        {
            //Arrange
            SalaryCalculator sc = new SalaryCalculator();

            //Act
            decimal hourlyWage = sc.GetHourlyWage(52000);

            //Assert
            Assert.AreEqual(25, hourlyWage);

        }
    }
}
