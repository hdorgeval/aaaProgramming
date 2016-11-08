using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.StringExtensions
{
    [TestClass]
    public class IsEqualTo
    {
        [TestMethod]
        public void ShouldReturnTrueWhenInputIsNullAndValueIsNull()
        {
            //Arrange
            string input = null;
            string value = null;

            //Act
            var result = input.IsEqualTo(value,StringComparison.CurrentCulture);

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnFalseWhenInputIsNullAndValueIsNotNull()
        {
            //Arrange
            string input = null;
            string value = "";

            //Act
            var result = input.IsEqualTo(value, StringComparison.CurrentCulture);

            //Assert
            var expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnFalseWhenInputIsNotNullAndValueIsNull()
        {
            //Arrange
            string input = "";
            string value = null;

            //Act
            var result = input.IsEqualTo(value, StringComparison.CurrentCulture);

            //Assert
            var expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsSameAsValueAndIsEmpty()
        {
            //Arrange
            string input = "";
            string value = "";

            //Act
            var result = input.IsEqualTo(value, StringComparison.CurrentCulture);

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsSameAsValueAndIsNotEmpty()
        {
            //Arrange
            string input = "test";
            string value = "test";

            //Act
            var result = input.IsEqualTo(value, StringComparison.CurrentCulture);

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }
    }
}
