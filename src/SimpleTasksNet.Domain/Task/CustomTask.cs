namespace SimpleTasksNet.Domain
{
    public class CustomTask
    {
        public string Line { get; private set; }

        public CustomTask(string line)
        {
            Line = line; 
        }
    }
}