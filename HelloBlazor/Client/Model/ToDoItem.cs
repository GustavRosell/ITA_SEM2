using System;
namespace HelloBlazor.Client.Model
{
    public class ToDoItem
    {
        public bool IsDone { get; set; }
        public required string Title { get; set; }
    }
}

