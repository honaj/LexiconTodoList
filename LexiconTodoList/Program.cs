List<TodoItem> pendingItems = new();
List<TodoItem> finishedItems = new();
int selectionIndex = 0;

await LoadTodoItems();
SelectionMenu();
return;

void SelectionMenu()
{
    var MainMenuItems = new[] {"Show task list", "Add a new task",  "Edit tasks", "Save and quit"};
    
    Console.WriteLine("Welcome to your todo-list!");
    Console.WriteLine("You have " + pendingItems.Count + " unfinished tasks and " + finishedItems.Count + " tasks are done!");
    Console.WriteLine("Pick an option:");
    
    
    ConsoleKeyInfo keyInfo;
    while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
    {
        switch (keyInfo.Key)
        {
            case ConsoleKey.UpArrow:
                if(selectionIndex < MainMenuItems.Length - 1)
                    selectionIndex++;
                break;
            
            case ConsoleKey.DownArrow:
                if(selectionIndex > 0)
                    selectionIndex--;
                break;
            
            case ConsoleKey.Enter:
                Console.WriteLine("select");
                break;
        }
        Console.WriteLine(MainMenuItems[selectionIndex]);
    }
    SelectionMenu();
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