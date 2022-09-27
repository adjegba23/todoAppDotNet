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
        }

        public void PrintTodoList()
        {
            foreach (TodoItem todo in TodoList)
            {
                Console.WriteLine(todo.ToString());
            }
        }
    }
}