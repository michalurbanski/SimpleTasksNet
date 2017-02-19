using System;

namespace SimpleTasksNet.Business.Tests
{
    internal class TaskParser
    {
        internal bool IsTask(string line)
        {
            if (string.IsNullOrEmpty(line))
            {
                return false; 
            }

            if (line.StartsWith("- "))
            {
                return true; 
            }

            return false; 
        }
    }
}