using NUnit.Framework;

namespace SimpleTasksNet.Business.Tests
{
    [TestFixture]
    class DayParserTests
    {
        private readonly DayParser _parser = new DayParser(); 

        [Test]
        [TestCase("Monday 2017-02-20")]
        [TestCase("Tuesday 2017-02-21")]
        [TestCase("Wednesday 2017-02-22")]
        [TestCase("Thursday 2017-02-23")]
        [TestCase("Friday 2017-02-24")]
        [TestCase("Saturday 2017-02-25")]
        [TestCase("Sunday 2017-02-26")]
        public void test_parse_correct_day(string line)
        {
            Assert.That(act(line), Is.True);
        }

        [Test]
        [TestCase("Monday")]
        [TestCase("Monday 2017-02-20 test")]
        [TestCase("Mon day")]
        [TestCase("Monday 2017")]
        public void test_parse_incorrect_line_parts(string line)
        {
            Assert.That(act(line), Is.False); 
        }

        [Test]
        public void test_parse_null_day()
        {
            string line = null;

            Assert.That(act(line), Is.False); 
       }

        [Test]
        public void test_parse_empty_day()
        {
            string line = string.Empty;

            Assert.That(act(line), Is.False);
        }

        private bool act(string line)
        {
            return _parser.IsDay(line); 
        }
    }
}
