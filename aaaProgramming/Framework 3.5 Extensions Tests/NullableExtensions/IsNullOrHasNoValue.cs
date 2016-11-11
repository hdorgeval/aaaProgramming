using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.NullableExtensions
{
    [TestClass]
    public class IsNullOrHasNoValue
    {
        [TestMethod]
        public void ShouldReturnTrueWhenInputIsNull()
        {
            //Arrange
            DateTime? input = null;


            //Act
            var result = input.IsNullOrHasNoValue();

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsNotNullAndHasNoValue()
        {
            //Arrange
            DateTime? input = new System.Nullable<DateTime>();


            //Act
            var result = input.IsNullOrHasNoValue();

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnFalseWhenInputIsNotNullAndHasValue()
        {
            //Arrange
            DateTime? input = new DateTime(2016,8,25);

            //Act
            var result = input.IsNullOrHasNoValue();

            //Assert
            var expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }
    }
}
