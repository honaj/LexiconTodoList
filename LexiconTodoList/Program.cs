Console.WriteLine("Welcome to your todo-list!");
Console.WriteLine("You x unfinished tasks and y tasks are done!");

List<TodoItem> pendingItems = new();
List<TodoItem> finishedItems = new();

MainLoop();
return;

void MainLoop()
{
    
}

async Task LoadTodoItems()
{
    try
    {
        var jsonPath = "TodoData.json";
    }
    catch
    {
        
    }
}

void PrintPendingItems()
{
    Console.WriteLine("rtest");
}

public class TodoItem
{
    public bool Done;
    public string Name;
    public DateTime DueDate;
    public string Project;

    public TodoItem(bool done, string name, DateTime dueDate, string project)
    {
        Done = done;
        Name = name;
        DueDate = dueDate;
        Project = project;
    }
}