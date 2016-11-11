using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.NullableExtensions
{
    [TestClass]
    public class ToValueOrDbNull
    {
        [TestMethod]
        public void ShouldReturnDbNullWhenInputIsNull()
        {
            //Arrange
            int? input = null;
            
            //Act
            var result = input.ToValueOrDbNull();

            //Assert
            var expected = DBNull.Value;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturnDbNullValueWhenInputHasNoValue()
        {
            //Arrange
            int? input = new System.Nullable<int>();

            //Act
            var result = input.ToValueOrDbNull();

            //Assert
            var expected = DBNull.Value;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnValueWhenInputIsNotNullAndHasValue()
        {
            //Arrange
            int? input = 5;

            //Act
            var result = input.ToValueOrDbNull();

            //Assert
            var expected = input.Value;
            if ((int)result != expected)
            {
                Assert.Fail();
            }
        }




    }
}
