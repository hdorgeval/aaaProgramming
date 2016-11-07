using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.StringExtensions
{
    [TestClass]
    public class ToStringOrDefault
    {
        [TestMethod]
        public void ShouldReturnDefaultValueWhenInputIsNull()
        {
            //Arrange
            string input = null;
            string defaultValue = "test";

            //Act
            var result = input.ToStringOrDefault(defaultValue);

            //Assert
            var expected = defaultValue;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnEmptyValueWhenInputIsEmpty()
        {
            //Arrange
            string input = string.Empty;
            string defaultValue = "test";

            //Act
            var result = input.ToStringOrDefault(defaultValue);

            //Assert
            var expected = input;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


    }
}
