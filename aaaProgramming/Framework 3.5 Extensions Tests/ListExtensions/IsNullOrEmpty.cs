using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.ListExtensions
{
    [TestClass]
    public class IsNullOrEmpty
    {
        [TestMethod]
        public void ShouldReturnTrueWhenInputIsNull()
        {
            //Arrange
            List<string> input = null;

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
            List<string> input = new List<string>() ;

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
            List<string> input = new List<string>();
            input.Add("test");

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
