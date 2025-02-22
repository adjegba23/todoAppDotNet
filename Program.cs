﻿using System;

namespace ToDoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoApp todoApp = new TodoApp();
        
            TodoItem todoItem1 = new TodoItem("Task 1", "Create TodoItem Object.", true);
            TodoItem todoItem2 = new TodoItem("Task 2", "Create TodoApp List<TodoItem> implementation.", true);
            TodoItem todoItem3 = new TodoItem("Task 3", "Add Int Priority Field to TodoItem.", false);
            TodoItem todoItem4 = new TodoItem("Task 4", "Add SortByPriority() to TodoApp.", false);

            // NOTE: The var and foreach loop below are just syntactic sugar to minimize repetition
 
            var todoItems = new List<TodoItem> { todoItem1, todoItem2, todoItem3, todoItem4 };

            foreach (TodoItem todoItem in todoItems)
            {
                todoApp.AddItem(todoItem);
            }

            todoApp.PrintTodoList();
        }
    }
}