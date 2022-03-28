namespace DataStructures.Queue
{
    public class EmptyQueueException : Exception
    {
        private string message;
        public EmptyQueueException(string message = "Queue is empty.") : base(message)
        {

        }
    }
}