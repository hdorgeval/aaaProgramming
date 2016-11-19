using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.StringExtensions
{
    [TestClass]
    public class IsIn
    {
        [TestMethod]
        public void ShouldReturnFalseWhenInputIsNull()
        {
            //Arrange
            string input = null;
            var values = new string[] { "false", "no", "faux", "non" };

            //Act
            var result = input.IsIn(values,StringComparison.CurrentCulture);

            //Assert
            var expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnFalseWhenInputIsEmpty()
        {
            //Arrange
            string input = string.Empty;
            var values = new string[] { "false", "no", "faux", "non" };

            //Act
            var result = input.IsIn(values, StringComparison.CurrentCulture);

            //Assert
            var expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnFalseWhenInputIsNotNullAndNotEmptyAndValuesIsNull()
        {
            //Arrange
            string input = "test";
            string[] values = null;

            //Act
            var result = input.IsIn(values, StringComparison.CurrentCulture);

            //Assert
            var expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturnFalseWhenInputIsNotNullAndNotEmptyAndValuesIsEmpty()
        {
            //Arrange
            string input = "test";
            string[] values = new string[] { } ;

            //Act
            var result = input.IsIn(values, StringComparison.CurrentCulture);

            //Assert
            var expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnFalseWhenInputIsNotNullAndNotEmptyAndValuesIsNotNullOREmptyAndDoesNotContainInput()
        {
            //Arrange
            string input = "test";
            string[] values = new string[] { "false", "no", "faux", "non" };

            //Act
            var result = input.IsIn(values, StringComparison.CurrentCulture);

            //Assert
            var expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsNotNullAndNotEmptyAndValuesIsNotNullOREmptyAndContainInput()
        {
            //Arrange
            string input = "no";
            string[] values = new string[] { "false", "no", "faux", "non" };

            //Act
            var result = input.IsIn(values, StringComparison.CurrentCulture);

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

    }
}
