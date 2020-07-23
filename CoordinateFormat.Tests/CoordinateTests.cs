using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoordinateFormat.Tests
{
    [TestClass]
    public class CoordinateTests
    {
        [TestMethod]
        public void Input_rightCoordinate_returnedFormattedCoordinates()
        {
            // arrange
            string coordinate = "23.8976,12.3218";
            string expected = "X: 23,8976 Y: 12,3218";

            // act
            string actual = Сoordinate.formatCoordinate(coordinate);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_wrongNumberCoordinates_returnedError()
        {
            // arrange
            string coordinate = "23.8976,12.3218, 28.4568";
            string expected = $"Incorrect input number of coordinates. Inputted data {coordinate}";

            // act
            string actual = Сoordinate.formatCoordinate(coordinate);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_extraSpaceCoordinates_returnedFormattedCoordinates()
        {
            // arrange
            string coordinate = "23.8976,         12.3218";
            string expected = $"X: 23,8976 Y: 12,3218";

            // act
            string actual = Сoordinate.formatCoordinate(coordinate);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_wordsCoordinates_returnedError()
        {
            // arrange
            string coordinate = "abcd, acfs";
            string expected = $"Incorrect input data or format coordinates. Inputted data {coordinate}";

            // act
            string actual = Сoordinate.formatCoordinate(coordinate);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_wordCoordinate_returnedError()
        {
            // arrange
            string coordinate = "abcdacfs";
            string expected = $"Incorrect input number of coordinates. Inputted data {coordinate}";

            // act
            string actual = Сoordinate.formatCoordinate(coordinate);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_dotCoordinates_returnedError()
        {
            // arrange
            string coordinate = "23.8976.12.3218, 25.957.15.3418";
            string expected = $"Incorrect input data or format coordinates. Inputted data {coordinate}";

            // act
            string actual = Сoordinate.formatCoordinate(coordinate);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_commaCoordinates_returnedError()
        {
            // arrange
            string coordinate = "23,8976,12,3218";
            string expected = $"Incorrect input number of coordinates. Inputted data {coordinate}";

            // act
            string actual = Сoordinate.formatCoordinate(coordinate);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Input_underlineCoordinate_returnedError()
        {
            // arrange
            string coordinate = "23.8976_12.3218";
            string expected = $"Incorrect input number of coordinates. Inputted data {coordinate}";

            // act
            string actual = Сoordinate.formatCoordinate(coordinate);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}
