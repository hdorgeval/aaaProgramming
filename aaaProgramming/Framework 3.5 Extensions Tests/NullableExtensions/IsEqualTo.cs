using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;

namespace FrameworkExtensionsTests.NullableExtensions
{
    [TestClass]
    public class IsEqualTo
    {
        [TestMethod]
        public void ShouldReturnTrueWhenInputIsNullAndValueIsNull()
        {
            //Arrange
            DateTime? input = null;
            DateTime? value = null;

            //Act
            var result = input.IsEqualTo(value);

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
            DateTime? input = null;
            DateTime? value = new System.DateTime(2017, 5, 28);

            //Act
            var result = input.IsEqualTo(value);

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
            DateTime? input = new System.DateTime(2017, 5, 28);
            DateTime? value = null;

            //Act
            var result = input.IsEqualTo(value);

            //Assert
            var expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsSameAsValueAndIsDateTime()
        {
            //Arrange
            DateTime? input = new System.DateTime(2017, 5, 28);
            DateTime? value = new System.DateTime(2017, 5, 28);

            //Act
            var result = input.IsEqualTo(value);

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsSameAsValueAndIsInt32()
        {
            //Arrange
            int? input = 5;
            int? value = 5;

            //Act
            var result = input.IsEqualTo(value);

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnTrueWhenInputIsSameAsValueAndIsBoolean()
        {
            //Arrange
            bool? input = false;
            bool? value = false;

            //Act
            var result = input.IsEqualTo(value);

            //Assert
            var expected = true;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnFalseWhenInputIsNotSameAsValueAndIsDateTime()
        {
            //Arrange
            DateTime? input = new System.DateTime(2017, 5, 28);
            DateTime? value = new System.DateTime(2017, 5, 29);

            //Act
            var result = input.IsEqualTo(value);

            //Assert
            var expected = false;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        


    }
}
