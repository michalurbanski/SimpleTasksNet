using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasksNet.Business.Tests
{
    [TestFixture]
    class LinesToWeeksConverterTests
    {
        [Test]
        public void test_multiple_weeks_null_input()
        {
            List<string> lines = null;

            var weeks = act(lines);

            Assert.IsEmpty(weeks); 
        }

        [Test]
        public void test_multiple_weeks_empty_input_collection()
        {
            var lines = new List<string>();

            var weeks = act(lines);

            Assert.IsEmpty(weeks); 
        }

        [Test]
        public void test_multiple_weeks_two_weeks_should_be_found()
        {
            var lines = new List<string>();
            lines.Add("Week 1");
            lines.Add("");
            lines.Add("Wednesday 2017-02-17"); 
            lines.Add("Week 2");

            var weeks = act(lines);

            Assert.IsNotEmpty(weeks);
            Assert.True(weeks.Count == 2);
        }

        private List<Week> act(IEnumerable<string> lines)
        {
            LinesToWeeksConverter converter = new LinesToWeeksConverter();

            return converter.ConvertToWeek(lines); 
        }
    }
}
