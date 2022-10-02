namespace ToDoApp
{
    class TodoApp
    {
        public TodoApp()
        {
            TodoList = new List<TodoItem>();
        }

        public List<TodoItem> TodoList { get; }

        public void AddItem(TodoItem todo)
        {
            TodoList.Add(todo);
            TodoList.Sort(delegate(TodoItem x,TodoItem y)
            {
                return x.Priority.CompareTo(y.Priority);
            });
        }

        public void PrintTodoList()
        {
            foreach (TodoItem todo in TodoList)
            {
                Console.WriteLine(todo.ToString());
            }
        }

        public void SortByPriority()
        {
            var nums = new List<TodoItem>();
            var orderByResultAscending = from s in nums
                                         orderby s.Priority ascending
                                         select s;

                
        }
    }
}