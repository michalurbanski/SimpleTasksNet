using NUnit.Framework;

namespace SimpleTasksNet.Business.Tests
{
    [TestFixture]
    class WeekParserTests
    {
        WeekParser _parser = new WeekParser();

        [Test]
        public void test_parse_correct_week()
        {
            string line = "Week 1";

            Assert.True(act(line)); 
        }

        [Test]
        public void test_parse_correct_lowercase_week()
        {
            string line = "week 1";

            Assert.True(act(line));
        }

        [Test]
        public void test_parse_empty_week()
        {
            string line = string.Empty;

            Assert.False(act(line)); 
        }

        [Test]
        public void test_parse_null_week()
        {
            string line = null;

            Assert.False(act(line)); 
        }

        [Test]
        public void test_parse_incorrect_week()
        {
            string line = "wkk 1"; 

            Assert.False(act(line));
        }

        private bool act(string line)
        {
            return _parser.IsWeek(line); 
        }
    }
}
