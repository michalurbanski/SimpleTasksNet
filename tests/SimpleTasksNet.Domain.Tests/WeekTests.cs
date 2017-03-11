using NUnit.Framework;
using System;
using System.Linq;

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

        [Test]
        public void test_days_can_be_retrieved_from_week()
        {
            string title = "Monday 2017-03-11";

            Week week = new Week("Week 1");
            Day day = new Day(title);

            week.AddDay(day);

            Assert.That(week.Days.First().Title == title); 
        }
    }
}
