using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.StringExtensions
{
    [TestClass]
    public class RemoveCurrencySymbols
    {
        [TestMethod]
        public void ShouldReturnNullWhenInputIsNull()
        {
            //Arrange
            string input = null;
            string[] values = null;

            //Act
            var result = input.RemoveCurrencySymbol();

            //Assert
            string expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnEmptyWhenInputIsEmpty()
        {
            //Arrange
            string input = string.Empty;
            string[] values = null;

            //Act
            var result = input.RemoveCurrencySymbol();

            //Assert
            string expected = string.Empty;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnEmptyWhenInputIsWhiteSpace()
        {
            //Arrange
            string input = " ";
            string[] values = null;

            //Act
            var result = input.RemoveCurrencySymbol();

            //Assert
            string expected = " ";
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnEmptyWhenInputIsWhiteSpaces()
        {
            //Arrange
            string input = "   ";
            string[] values = null;

            //Act
            var result = input.RemoveCurrencySymbol();

            //Assert
            string expected = "   ";
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn123WhenInputIs123Euro()
        {
            //Arrange
            string input = "123€";
            string[] values = null;

            //Act
            var result = input.RemoveCurrencySymbol();

            //Assert
            string expected = "123";
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn123WhenInputIs123UsDollard()
        {
            //Arrange
            string input = "123$";
            string[] values = null;

            //Act
            var result = input.RemoveCurrencySymbol();

            //Assert
            string expected = "123";
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn123WhenInputIs123EnglishPound()
        {
            //Arrange
            string input = "123£";
            string[] values = null;

            //Act
            var result = input.RemoveCurrencySymbol();

            //Assert
            string expected = "123";
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn123WhenInputIs123Yen()
        {
            //Arrange
            string input = "123¥";

            //Act
            var result = input.RemoveCurrencySymbol();

            //Assert
            string expected = "123";
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn123WhenInputIs123VietnamDong()
        {
            //Arrange
            string input = "123₫";

            //Act
            var result = input.RemoveCurrencySymbol("₫");

            //Assert
            string expected = "123";
            if (result != expected)
            {
                Assert.Fail();
            }
        }


    }
}
