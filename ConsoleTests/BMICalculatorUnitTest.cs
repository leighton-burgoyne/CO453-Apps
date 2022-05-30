using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App02;

namespace ConsoleTests
{
    [TestClass]
    public class BMICalculatorUnitTest
    {
        /// <summary>
        /// Test Method for Testing Lower Boundary of Underweight with Metric System
        /// </summary>
        [TestMethod]
        public void TestUnderweightMetricLower()
        {
            // Arrange
            BMICalculator calculator = new BMICalculator();
            calculator.Centimetres = 100;
            calculator.Kilograms = 0;

            // Act
            calculator.CalculateMetric();
            double expectedBMI = 00.00;

            // Assert
            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        /// <summary>
        /// Test Method for Testing Upper Boundary of Underweight with Metric System
        /// </summary>
        [TestMethod]
        public void TestUnderweightMetricUpper()
        {
            // Arrange
            BMICalculator calculator = new BMICalculator();
            calculator.Centimetres = 100;
            calculator.Kilograms = 18.49;

            // Act
            calculator.CalculateMetric();
            double expectedBMI = 18.49;

            // Assert
            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        /// <summary>
        /// Test Method for Testing Lower Boundary of Normal with Metric System
        /// </summary>
        [TestMethod]
        public void TestNormalMetricLower()
        {
            // Arrange
            BMICalculator calculator = new BMICalculator();
            calculator.Centimetres = 100;
            calculator.Kilograms = 18.5;

            // Act
            calculator.CalculateMetric();
            double expectedBMI = 18.50;

            // Assert
            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        /// <summary>
        /// Test Method for Testing Upper Boundary of Normal with Metric System
        /// </summary>
        [TestMethod]
        public void TestNormalMetricUpper()
        {
            // Arrange
            BMICalculator calculator = new BMICalculator();
            calculator.Centimetres = 100;
            calculator.Kilograms = 24.99;

            // Act
            calculator.CalculateMetric();
            double expectedBMI = 24.99;

            // Assert
            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        /// <summary>
        /// Test Method for Testing Lower Boundary of Overweight with Metric System
        /// </summary>
        [TestMethod]
        public void TestOverweightMetricLower()
        {
            // Arrange
            BMICalculator calculator = new BMICalculator();
            calculator.Centimetres = 100;
            calculator.Kilograms = 25.00;

            // Act
            calculator.CalculateMetric();
            double expectedBMI = 25.00;

            // Assert
            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        /// <summary>
        /// Test Method for Testing Upper Boundary of Overweight with Metric System
        /// </summary>
        [TestMethod]
        public void TestOverweightMetricUpper()
        {
            // Arrange
            BMICalculator calculator = new BMICalculator();
            calculator.Centimetres = 100;
            calculator.Kilograms = 29.99;

            // Act
            calculator.CalculateMetric();
            double expectedBMI = 29.99;

            // Assert
            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        /// <summary>
        /// Test Method for Testing Lower Boundary of Obese Class I with Metric System
        /// </summary>
        [TestMethod]
        public void TestObeseClassIMetricLower()
        {
            // Arrange
            BMICalculator calculator = new BMICalculator();
            calculator.Centimetres = 100;
            calculator.Kilograms = 30;

            // Act
            calculator.CalculateMetric();
            double expectedBMI = 30.00;

            // Assert
            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        /// <summary>
        /// Test Method for Testing Upper Boundary of Obese Class I with Metric System
        /// </summary>
        [TestMethod]
        public void TestObeseClassIMetricUpper()
        {
            // Arrange
            BMICalculator calculator = new BMICalculator();
            calculator.Centimetres = 100;
            calculator.Kilograms = 34.99;

            // Act
            calculator.CalculateMetric();
            double expectedBMI = 34.99;

            // Assert
            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        /// <summary>
        /// Test Method for Testing Lower Boundary of Obese Class II with Metric System
        /// </summary>
        [TestMethod]
        public void TestObeseClassIIMetricLower()
        {
            // Arrange
            BMICalculator calculator = new BMICalculator();
            calculator.Centimetres = 100;
            calculator.Kilograms = 35;

            // Act
            calculator.CalculateMetric();
            double expectedBMI = 35.00;

            // Assert
            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        /// <summary>
        /// Test Method for Testing Upper Boundary of Obese Class II with Metric System
        /// </summary>
        [TestMethod]
        public void TestObeseClassIIMetricUpper()
        {
            // Arrange
            BMICalculator calculator = new BMICalculator();
            calculator.Centimetres = 100;
            calculator.Kilograms = 39.99;

            // Act
            calculator.CalculateMetric();
            double expectedBMI = 39.99;

            // Assert
            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        /// <summary>
        /// Test Method for Testing Lower Boundary of Obese Class III with Metric System
        /// </summary>
        [TestMethod]
        public void TestObeseClassIIIMetricLower()
        {
            // Arrange
            BMICalculator calculator = new BMICalculator();
            calculator.Centimetres = 100;
            calculator.Kilograms = 40;

            // Act
            calculator.CalculateMetric();
            double expectedBMI = 40.00;

            // Assert
            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }

        /// <summary>
        /// Test Method for Testing Upper Boundary of Obese Class III with Metric System
        /// </summary>
        [TestMethod]
        public void TestObeseClassIIIMetricUpper()
        {
            // Arrange
            BMICalculator calculator = new BMICalculator();
            calculator.Centimetres = 100;
            calculator.Kilograms = 100;

            // Act
            calculator.CalculateMetric();
            double expectedBMI = 100.00;

            // Assert
            Assert.AreEqual(expectedBMI, calculator.Bmi);
        }
    }
}