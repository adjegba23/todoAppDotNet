using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoItem testItem = new TodoItem("Test Task", "Testing the task description field.", true);
            Console.WriteLine(testItem.ToString());
        }
    }
}