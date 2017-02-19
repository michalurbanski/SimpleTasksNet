namespace SimpleTasksNet.Business
{
    public class TaskParser
    {
        public bool IsTask(string line)
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