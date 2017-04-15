using NUnit.Framework;
using SimpleTasksNet.Common.Helpers;
using System;

namespace SimpleTasksNet.Common.Tests
{
    [TestFixture]
    class DayHelperTests
    {
        [Test]
        public void test_extract_date_from_day_line()
        {
            string line = "Monday 2017-04-17";

            DateTime date = DayHelper.ExtractDate(line);

            Assert.That(date == new DateTime(2017, 4, 17));
        }

        [Test]
        public void test_extract_date_from_day_line_fails_when_date_format_is_invalid()
        {
            string line = "Monday 2017/04/17";

            Assert.Throws<ArgumentException>(() => DayHelper.ExtractDate(line)); 
        }

        [Test]
        public void test_empty_day_line_throws_exception()
        {
            string line = string.Empty;

            Assert.Throws<ArgumentException>(() => DayHelper.ExtractDate(line)); 
        }
    }
}
