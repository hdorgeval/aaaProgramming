using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.StringExtensions
{
    [TestClass]
    public class RemoveCurrencySymbol
    {
        [TestMethod]
        public void ShouldReturnNullWhenInputIsNull()
        {
            //Arrange
            string input = null;

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

            //Act
            var result = input.RemoveCurrencySymbol(CurrencySymbol.Euro);

            //Assert
            string expected = "123";
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn123WhenInputIs123EuroNoExplicit()
        {
            //Arrange
            string input = "123€";

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

            //Act
            var result = input.RemoveCurrencySymbol(CurrencySymbol.Dollar);

            //Assert
            string expected = "123";
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn123WhenInputIs123UsDollardNoExplicit()
        {
            //Arrange
            string input = "123$";

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

            //Act
            var result = input.RemoveCurrencySymbol(CurrencySymbol.Pound);

            //Assert
            string expected = "123";
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn123WhenInputIs123EnglishPoundNoExplicit()
        {
            //Arrange
            string input = " 123 £ ";

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
            var result = input.RemoveCurrencySymbol(CurrencySymbol.Yen);

            //Assert
            string expected = "123";
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn123WhenInputIs123YenNoExplicit()
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
        public void ShouldReturn123WhenInputIs123SwissFranc()
        {
            //Arrange
            string input = "123 CHF";

            //Act
            var result = input.RemoveCurrencySymbol(CurrencySymbol.SwissFranc);

            //Assert
            string expected = "123";
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn123WhenInputIs123SwissFrancNoExplicit()
        {
            //Arrange
            string input = "123 CHF";

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
            string input = "123 ₫";

            //Act
            var result = input.RemoveCurrencySymbol("₫");

            //Assert
            string expected = "123";
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturn123WhenInputIs123VietnamDongNoExplicit()
        {
            //Arrange
            string input = "123 ₫";

            //Act
            var result = input.RemoveCurrencySymbol();

            //Assert
            string expected = "123";
            if (result != expected)
            {
                Assert.Fail();
            }
        }


    }
}
