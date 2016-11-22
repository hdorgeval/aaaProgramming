using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;
using System.Globalization;

namespace FrameworkExtensionsTests.StringExtensions
{
    [TestClass]
    public class ToBooleanOrDefault
    {
        [TestMethod]
        public void ShouldReturnNullWhenInputIsNull()
        {
            //Arrange
            string input = null;

            //Act
            var result = input.ToBooleanOrDefault();

            //Assert
            bool? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsEmpty()
        {
            //Arrange
            string input = string.Empty;

            //Act
            var result = input.ToBooleanOrDefault();

            //Assert
            bool? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsWhiteSpace()
        {
            //Arrange
            string input = " ";

            //Act
            var result = input.ToBooleanOrDefault();

            //Assert
            bool? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsWhiteSpaces()
        {
            //Arrange
            string input = "     ";

            //Act
            var result = input.ToBooleanOrDefault();

            //Assert
            bool? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturnTrueWhenInputIs1()
        {
            //Arrange
            string input = "1";

            //Act
            var result = input.ToBooleanOrDefault();

            //Assert
            bool? expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsYesLowerCase()
        {
            //Arrange
            string input = "yes";

            //Act
            var result = input.ToBooleanOrDefault();

            //Assert
            bool? expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsYesUpperCase()
        {
            //Arrange
            string input = "YES";

            //Act
            var result = input.ToBooleanOrDefault();

            //Assert
            bool? expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnFalseWhenInputIs0()
        {
            //Arrange
            string input = "0";

            //Act
            var result = input.ToBooleanOrDefault();

            //Assert
            bool? expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnFalseWhenInputIs0WIthWhiteSpaceBefore()
        {
            //Arrange
            string input = " 0";

            //Act
            var result = input.ToBooleanOrDefault();

            //Assert
            bool? expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        


        
    }
}
