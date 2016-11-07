using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.StringExtensions
{
    [TestClass]
    public class IsNullOrEmptyOrWhiteSpace
    {
        [TestMethod]
        public void ShouldReturnTrueWhenInputIsNull()
        {
            //Arrange
            string input = null;

            //Act
            var result = input.IsNullOrEmptyOrWhiteSpace();

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsEmpty()
        {
            //Arrange
            string input = string.Empty;

            //Act
            var result = input.IsNullOrEmptyOrWhiteSpace();

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsOneWhiteSpace()
        {
            //Arrange
            string input = " ";

            //Act
            var result = input.IsNullOrEmptyOrWhiteSpace();

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsTwoWhiteSpaces()
        {
            //Arrange
            string input = "  ";

            //Act
            var result = input.IsNullOrEmptyOrWhiteSpace();

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsNWhiteSpaces()
        {
            //Arrange
            string input = "                                      ";

            //Act
            var result = input.IsNullOrEmptyOrWhiteSpace();

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnFalseWhenInputIsNotNullAndNotEmptyAndNotWhiteSpace()
        {
            //Arrange
            string input = " test ";
            
            //Act
            var result = input.IsNullOrEmptyOrWhiteSpace();

            //Assert
            var expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


    }
}
