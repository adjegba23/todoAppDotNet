namespace ToDoApp
{
    class TodoItem
    {
        public TodoItem(string taskTitle, string taskDescription, bool taskIsCompleted, int priority)
        {
            TaskTitle = taskTitle;
            TaskDescription = taskDescription;
            TaskIsCompleted = taskIsCompleted;
            Priority = priority;
        }

        public string TaskTitle { get; }
        public string TaskDescription { get; }
        public bool TaskIsCompleted { get; }
        public int Priority { get; }

        public override string ToString()
        {
            return "\n" + "TITLE: " + TaskTitle + "\nDESCRIPTION: " + TaskDescription + "\nCOMPLETED: " + TaskIsCompleted + "\n" + "PRIORITY" + Priority;
        }
    }
}