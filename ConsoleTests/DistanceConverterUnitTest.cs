using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleTests
{
    [TestClass]
    public class DistanceConverterUnitTest
    {
        /// <summary>
        /// Test Method for Testing Miles to Feet Conversion
        /// </summary>
        [TestMethod]
        public void TestMilesToFeet()
        {
            // Arrange
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Feet;
            converter.FromValue = 2.0;

            // Act
            converter.ConvertDistance();
            double expectedDistance = 10560;

            // Assert
            Assert.AreEqual(expectedDistance, converter.ToValue);
        }

        /// <summary>
        /// Test Method for Testing Feet to Miles Conversion
        /// </summary>
        [TestMethod]
        public void TestFeetToMiles()
        {
            // Arrange
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;
            converter.FromValue = 10560;

            // Act
            converter.ConvertDistance();
            double expectedDistance = 2.0;

            // Assert
            Assert.AreEqual(expectedDistance, converter.ToValue);
        }

        /// <summary>
        /// Test Method for Testing Miles to Metres Conversion
        /// </summary>
        [TestMethod]
        public void TestMilesToMetres()
        {
            // Arrange
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Metres;
            converter.FromValue = 10;

            // Act
            converter.ConvertDistance();
            double expectedDistance = 16093.4;

            // Assert
            Assert.AreEqual(expectedDistance, converter.ToValue);
        }

        /// <summary>
        /// Test Method for Testing Metres to Miles Conversion
        /// </summary>
        [TestMethod]
        public void TestMetresToMiles()
        {
            // Arrange
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Miles;
            converter.FromValue = 10460.71;

            // Act
            converter.ConvertDistance();
            double expectedDistance = 6.5;

            // Assert
            Assert.AreEqual(expectedDistance, converter.ToValue);
        }

        /// <summary>
        /// Test Method for Testing Metres to Feet Conversion
        /// </summary>
        [TestMethod]
        public void TestMetresToFeet()
        {
            // Arrange
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Feet;
            converter.FromValue = 2.0;

            // Act
            converter.ConvertDistance();
            double expectedDistance = 6.56168;

            // Assert
            Assert.AreEqual(expectedDistance, converter.ToValue);
        }

        /// <summary>
        /// Test Method for Testing Feet to Metres Conversion
        /// </summary>
        [TestMethod]
        public void TestFeetToMetres()
        {
            // Arrange
            DistanceConverter converter = new DistanceConverter();
            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Metres;
            converter.FromValue = 29.52756;

            // Act
            converter.ConvertDistance();
            double expectedDistance = 9.0;

            // Assert
            Assert.AreEqual(expectedDistance, converter.ToValue);
        }
    }
}