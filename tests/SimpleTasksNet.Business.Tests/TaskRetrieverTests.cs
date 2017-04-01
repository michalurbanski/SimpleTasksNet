using NUnit.Framework;
using SimpleTasksNet.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTasksNet.Business.Tests
{
    [TestFixture]
    class TaskRetrieverTests
    {
        [Test]
        public void test_week_without_days_has_no_tasks()
        {
            Week week = new Week("Week 1");

            TaskRetriever taskRetriever = new TaskRetriever();
            IEnumerable<CustomTask> tasks = taskRetriever.GetTasks(week);
        }

        [Test]
        public void test_week_with_days_with_no_tasks()
        {
            Assert.Inconclusive(); 
        }

        [Test]
        public void test_retrieve_tasks_from_week_single_day()
        {
            Assert.Inconclusive(); 
        }

        [Test]
        public void test_retrieve_tasks_from_week_multiple_days()
        {
            Assert.Inconclusive(); 
        }
    }
}
