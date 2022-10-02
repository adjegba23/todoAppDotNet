using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoApp todoApp = new TodoApp();
        
            TodoItem todoItem1 = new TodoItem("Task 1", "Create TodoItem Object.", true, 5);
            TodoItem todoItem2 = new TodoItem("Task 2", "Create TodoApp List<TodoItem> implementation.", true, 2);
            TodoItem todoItem3 = new TodoItem("Task 3", "Add Int Priority Field to TodoItem.", false, 6);
            TodoItem todoItem4 = new TodoItem("Task 4", "Add SortByPriority() to TodoApp.", false, 4);

            // NOTE: The var and foreach loop below are just syntactic sugar to minimize repetition
 
            var todoItems = new List<TodoItem> { todoItem1, todoItem2, todoItem3, todoItem4 };

            foreach (TodoItem todoItem in todoItems)
            {
                todoApp.AddItem(todoItem);
            }
            todoApp.SortByPriority();

            todoApp.PrintTodoList();
        }
    }
}