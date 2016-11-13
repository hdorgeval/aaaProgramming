using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;
using System.Globalization;

namespace FrameworkExtensionsTests.StringExtensions
{
    [TestClass]
    public class ToInt32OrDefault
    {
        [TestMethod]
        public void ShouldReturnNullWhenInputIsNull()
        {
            //Arrange
            string input = null;

            //Act
            var result = input.ToInt32OrDefault();

            //Assert
            int? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsEmpty()
        {
            //Arrange
            string input = string.Empty;

            //Act
            var result = input.ToInt32OrDefault();

            //Assert
            int? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsWhiteSpace()
        {
            //Arrange
            string input = " ";

            //Act
            var result = input.ToInt32OrDefault();

            //Assert
            int? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsWhiteSpaces()
        {
            //Arrange
            string input = "     ";

            //Act
            var result = input.ToInt32OrDefault();

            //Assert
            int? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturn0WhenInputIs0()
        {
            //Arrange
            string input = "0";

            //Act
            var result = input.ToInt32OrDefault();

            //Assert
            int? expected = 0;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn0WhenInputIs0WIthWhiteSpaceBefore()
        {
            //Arrange
            string input = " 0";

            //Act
            var result = input.ToInt32OrDefault();

            //Assert
            int? expected = 0;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn0WhenInputIs0WIthWhiteSpacesBefore()
        {
            //Arrange
            string input = "     0";

            //Act
            var result = input.ToInt32OrDefault();

            //Assert
            int? expected = 0;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturn0WhenInputIs0WIthWhiteSpacesBeforeAndAfter()
        {
            //Arrange
            string input = "     0    ";

            //Act
            var result = input.ToInt32OrDefault();

            //Assert
            int? expected = 0;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturn1234WhenInputIs1234WithThousandsSeparatorFr()
        {
            //Arrange
            string input = "1 234";

            //Act
            var result = input.ToInt32OrDefault();

            //Assert
            int? expected = 1234;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn1234WhenInputIs1234WithThousandsSeparatorEn()
        {
            //Arrange
            string input = "1,234";
            CultureInfo currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture;
            CultureInfo culture = new CultureInfo("en-US");
            System.Threading.Thread.CurrentThread.CurrentCulture = culture;

            //Act
            var result = input.ToInt32OrDefault();
            System.Threading.Thread.CurrentThread.CurrentCulture = currentCulture;

            //Assert
            int? expected = 1234;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturn1234WhenInputIs1234WithThousandsSeparatorFrAndPositiveSign()
        {
            //Arrange
            string input = "+1 234";

            //Act
            var result = input.ToInt32OrDefault();

            //Assert
            int? expected = 1234;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnMinus1234WhenInputIs1234WithThousandsSeparatorFrAndNegativeSign()
        {
            //Arrange
            string input = "-1 234";

            //Act
            var result = input.ToInt32OrDefault();

            //Assert
            int? expected = -1234;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturn1234WhenInputIs1234WithThousandsSeparatorFrAndPositiveSignWithCurrencyEuro()
        {
            //Arrange
            string input = "+1 234€";

            //Act
            var result = input.ToInt32OrDefault();

            //Assert
            int? expected = 1234;
            if (result != expected)
            {
                Assert.Fail();
            }
        }
    }
}
