using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.StringExtensions
{
    [TestClass]
    public class IsNullOrEmpty
    {
        [TestMethod]
        public void ShouldReturnTrueWhenInputIsNull()
        {
            //Arrange
            string input = null;

            //Act
            var result = input.IsNullOrEmpty();

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
            var result = input.IsNullOrEmpty();

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnFalseWhenInputIsNotNullAndNotEmpty()
        {
            //Arrange
            string input = "test";
            
            //Act
            var result = input.IsNullOrEmpty();

            //Assert
            var expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }
    }
}
