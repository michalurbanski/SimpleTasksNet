using NUnit.Framework;

namespace SimpleTasksNet.Business.Tests
{
    [TestFixture]
    public class TaskParserTests
    {
        private TaskParser _taskParser = new TaskParser(); 

        [Test]
        [TestCase("- First Task")]
        [TestCase("- delayed, - First Task")]
        [TestCase("- delayed, DONE 2017-02-21 - First Task")]
        [TestCase("- ABORTED - First Task")]
        [TestCase("- DONE - First task")]
        public void test_parse_correct_tasks(string line)
        {
            Assert.That(act(line), Is.True); 
        }

        [Test]
        [TestCase("")]
        [TestCase(null)]
        [TestCase("-- this is not a task")]
        [TestCase("--------- ")]
        public void test_parse_incorrect_tasks(string line)
        {
            Assert.That(act(line), Is.False);
        }

        private bool act(string line)
        {
            return _taskParser.IsTask(line); 
        }
    }
}
