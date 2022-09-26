namespace ToDoApp
{
    class TodoItem
    {
        public TodoItem(string taskTitle, string taskDescription, bool taskIsCompleted)
        {
            TaskTitle = taskTitle;
            TaskDescription = taskDescription;
            TaskIsCompleted = taskIsCompleted;
        }

        public string TaskTitle { get; }
        public string TaskDescription { get; }
        public bool TaskIsCompleted { get; }

        public override string ToString()
        {
            return "\n" + "TITLE: " + TaskTitle + "\nDESCRIPTION: " + TaskDescription + "\nCOMPLETED: " + TaskIsCompleted + "\n";
        }
    }
}