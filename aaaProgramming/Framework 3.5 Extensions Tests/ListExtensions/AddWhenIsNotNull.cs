using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.ListExtensions
{
    [TestClass]
    public class AddWhenIsNotNull
    {
        [TestMethod]
        public void ShouldDoNothingWhenInputIsNull()
        {
            //Arrange
            List<string> input = null;
            var item = "test";

            //Act
            input.AddWhenIsNotNull(item);

            //Assert
            List<string> expected = null;
            if (input != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldDoNothingWhenInputIsEmptyAndItemIsNull()
        {
            //Arrange
            List<string> input = new List<string>();
            string item = null;

            //Act
            input.AddWhenIsNotNull(item);
            var result = input.Count;

            //Assert
            var  expected = 0;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldAddWhenInputIsEmptyAndItemIsNotNull()
        {
            //Arrange
            List<string> input = new List<string>();
            string item = "";

            //Act
            input.AddWhenIsNotNull(item);
            var result = input.Count;

            //Assert
            var expected = 1;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


    }
}
