using NUnit.Framework;
using SimpleTasksNet.Common.Helpers;
using System;

namespace SimpleTasksNet.Common.Tests
{
    [TestFixture]
    class DayHelperTests
    {
        [Test]
        public void returns_valid_date_when_line_format_is_correct()
        {
            string line = "Monday 2017-04-17";

            DateTime date = DayHelper.ExtractDate(line);

            Assert.That(date == new DateTime(2017, 4, 17));
        }

        [Test]
        public void throws_exception_when_date_format_in_line_is_incorrect()
        {
            string line = "Monday 2017/04/17";

            Assert.Throws<ArgumentException>(() => DayHelper.ExtractDate(line)); 
        }

        [Test]
        public void throws_exception_when_line_is_empty()
        {
            string line = string.Empty;

            Assert.Throws<ArgumentException>(() => DayHelper.ExtractDate(line)); 
        }
    }
}
