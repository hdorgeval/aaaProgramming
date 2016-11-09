using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using FrameworkExtensions;


namespace FrameworkExtensionsTests.StringExtensions
{
    [TestClass]
    public class ToDateTimeOrDefault
    {
        [TestMethod]
        public void ShouldReturnNullWhenInputIsNull()
        {
            //Arrange
            string input = null;
            string datetimeFormat = StandardDateTimeFormat.ShortDatePattern;
            string culture = "fr-FR";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsEmpty()
        {
            //Arrange
            string input = "";
            string datetimeFormat = StandardDateTimeFormat.ShortDatePattern;
            string culture = "fr-FR";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = null;
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
            string datetimeFormat = StandardDateTimeFormat.ShortDatePattern;
            string culture = "fr-FR";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsShortDateAndDatetimeFormatIsNull()
        {
            //Arrange
            string input = @"28/05/2017";
            string datetimeFormat = null;
            string culture = "fr-FR";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsShortDateAndDatetimeFormatIsEmpty()
        {
            //Arrange
            string input = @"28/05/2017";
            string datetimeFormat = "";
            string culture = "fr-FR";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsShortDateAndDatetimeFormatIsWhiteSpace()
        {
            //Arrange
            string input = @"28/05/2017";
            string datetimeFormat = " ";
            string culture = "fr-FR";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsShortDateAndDatetimeFormatIsShortDatePatternAndCultureIsNull()
        {
            //Arrange
            string input = @"28/05/2017";
            string datetimeFormat = StandardDateTimeFormat.ShortDatePattern;
            string culture = null;

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsShortDateAndDatetimeFormatIsShortDatePatternAndCultureIsEmpty()
        {
            //Arrange
            string input = @"28/05/2017";
            string datetimeFormat = StandardDateTimeFormat.ShortDatePattern;
            string culture = "";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenInputIsShortDateAndDatetimeFormatIsShortDatePatternAndCultureIsWhiteSpace()
        {
            //Arrange
            string input = @"28/05/2017";
            string datetimeFormat = StandardDateTimeFormat.ShortDatePattern;
            string culture = " ";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = null;
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturnValidDateTimeWhenInputIsShortDateFrAndDatetimeFormatIsShortDatePatternAndCultureIsFrenchFrance()
        {
            //Arrange
            string input = @"28/05/2017";
            string datetimeFormat = StandardDateTimeFormat.ShortDatePattern;
            string culture = "fr-FR";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = new DateTime(2017,05,28);
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturnValidDateTimeWhenInputIsShortDateUSAndDatetimeFormatIsShortDatePatternAndCultureIsEnglishUS()
        {
            //Arrange
            string input = @"05/28/2017";
            string datetimeFormat = StandardDateTimeFormat.ShortDatePattern;
            string culture = "en-US";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = new DateTime(2017, 05, 28);
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturnValidDateTimeWhenInputIsShortDateShortTimeFrAndDatetimeFormatIsShortDateShortTimePatternAndCultureIsFrenchFrance()
        {
            //Arrange
            string input = @"28/05/2017 13:45";
            string datetimeFormat = StandardDateTimeFormat.ShortDateShortTimePattern;
            string culture = "fr-FR";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = new DateTime(2017, 05, 28,13,45,00);
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturnValidDateTimeWhenInputIsShortDateLongTimeFrAndDatetimeFormatIsShortDateLongTimePatternAndCultureIsFrenchFrance()
        {
            //Arrange
            string input = @"28/05/2017 13:45:30";
            string datetimeFormat = StandardDateTimeFormat.ShortDateLongTimePattern;
            string culture = "fr-FR";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = new DateTime(2017, 05, 28, 13, 45, 30);
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturnValidDateTimeWhenInputIsShortDateShortTimeUSAndDatetimeFormatIsShortDateShortTimePatternAndCultureIsEnglishUS()
        {
            //Arrange
            string input = @"05/28/2017 1:45 PM";
            string datetimeFormat = StandardDateTimeFormat.ShortDateShortTimePattern;
            string culture = "en-US";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = new DateTime(2017, 05, 28, 13, 45, 00);
            if (result != expected)
            {
                Assert.Fail();
            }
        }


        [TestMethod]
        public void ShouldReturnValidDateTimeWhenInputIsShortDateLongTimeUSAndDatetimeFormatIsShortDateLongTimePatternAndCultureIsEnglishUS()
        {
            //Arrange
            string input = @"05/28/2017 1:45:30 PM";
            string datetimeFormat = StandardDateTimeFormat.ShortDateLongTimePattern;
            string culture = "en-US";

            //Act
            var result = input.ToDateTimeOrDefault(datetimeFormat, culture);

            //Assert
            DateTime? expected = new DateTime(2017, 05, 28, 13, 45, 30);
            if (result != expected)
            {
                Assert.Fail();
            }
        }


    }
}
