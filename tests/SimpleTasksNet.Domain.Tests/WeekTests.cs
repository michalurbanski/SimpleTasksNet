using NUnit.Framework;
using System;

namespace SimpleTasksNet.Domain.Tests
{
    [TestFixture]
    class WeekTests
    {
        [Test]
        public void test_week_can_have_days()
        {
            Week week = new Week(string.Empty);
            Day day = new Day(string.Empty);

            week.AddDay(day);

            Assert.True(week.DaysCount == 1);
        }

        [Test]
        public void test_week_adding_null_day_throws_exception()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                Week week = new Week(string.Empty);
                Day day = null;

                week.AddDay(day);
            });
        }
    }
}
