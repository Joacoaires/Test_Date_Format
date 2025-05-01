using Ucu.Poo.TestDateFormat;
using NUnit.Framework;

namespace LibraryTests
{
    public class DateFormatterTests
    {
        [Test]
        public void FechaFormatoCorrecto()
        {
            // Arrange
            string testDate = "10/11/1997";

            // Act
            string changedDate = DateFormatter.ChangeFormat(testDate);

            // Assert
            Assert.That(changedDate, Is.EqualTo("1997-11-10"));
        }

        [Test]
        public void FechaFormatoEnBlanco_LanzaFormatException()
        {
            string testDate = "";

            Assert.Throws<FormatException>(() => DateFormatter.ChangeFormat(testDate));
        }

        [Test]
        public void FechaFormatoIncorrecto_LanzaFormatException()
        {
            string testDate = "10-11-1997";

            Assert.Throws<FormatException>(() => DateFormatter.ChangeFormat(testDate));
        }

        [Test]
        public void FechaNull_LanzaFormatException()
        {
            string testDate = null;

            Assert.Throws<FormatException>(() => DateFormatter.ChangeFormat(testDate));
        }
    }
}