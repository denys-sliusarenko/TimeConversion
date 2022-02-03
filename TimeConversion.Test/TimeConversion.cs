using FluentAssertions;
using NUnit.Framework;
using System;

namespace TimeConversion.Test
{
    public class Tests
    {

        [Test]
        [TestCase("07:05:45 PM", "19:05:45")]
        [TestCase("09:30:05 PM", "21:30:05")]
        [TestCase("11:23:45 PM", "23:23:45")]
        [TestCase("12:00:00 PM", "12:00:00")]
        [TestCase("04:06:03 PM", "16:06:03")]
        [TestCase("12:00:00 AM", "00:00:00")]
        [TestCase("03:05:00 AM", "03:05:00")]
        [TestCase("11:10:00 AM", "11:10:00")]
        [TestCase("11:10:00 am", "11:10:00")]
        [TestCase("12:00:00 pm", "12:00:00")]
        [TestCase("11:23:45 pm", "23:23:45")]
        public void GetTimeConversion_CorrectInputDateString_ReturnCorrectTime24hoursFormatString(string time12hoursFormatString, string expectedResult)
        {
            var actualResult = TimeConversion.GetTimeConversion(time12hoursFormatString);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        [TestCase("")]
        [TestCase("   ")]
        [TestCase("11:70:00 AM")]
        [TestCase("24:10:00 AM")]
        [TestCase("testString")]
        [TestCase("11:10:00")]
        [TestCase("323:10:00")]
        [TestCase("12:00:00 Pm")]
        [TestCase("03:05:00aM")]
        [TestCase("04:06:03 Am")]
        [TestCase("12:00:00pM")]
        public void GetTimeConversion_IncorrectInputDateString_ThrowFormatException(string time12hoursFormatString)
        {
            Action result = () => TimeConversion.GetTimeConversion(time12hoursFormatString);
            result.Should().Throw<FormatException>().WithMessage(string.Format("Unable to parse '{0}'.", time12hoursFormatString));
        }
    }
}