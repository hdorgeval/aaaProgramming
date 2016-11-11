using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.StringExtensions
{
    [TestClass]
    public class ToValueOrDefault
    {
        [TestMethod]
        public void ShouldReturnDefaultValueWhenInputIsNull()
        {
            //Arrange
            int? input = null;
            int defaultValue = 0;


            //Act
            var result = input.ToValueOrDefault(defaultValue);

            //Assert
            var expected = defaultValue;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturnDefaultValueWhenInputIsNotNullAndHasNoValue()
        {
            //Arrange
            int? input = new System.Nullable<int>();
            int defaultValue = 0;


            //Act
            var result = input.ToValueOrDefault(defaultValue);

            //Assert
            var expected = defaultValue;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnValueWhenInputIsNotNullAndHasValue()
        {
            //Arrange
            int? input = 1;
            int defaultValue = 0;


            //Act
            var result = input.ToValueOrDefault(defaultValue);

            //Assert
            var expected = 1;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


    }
}
