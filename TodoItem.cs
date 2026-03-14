// class is a blueprint for creating objects
public class TodoItem
{
    public string? Title { get; set; }
    // ? means the property is nullable
    public bool IsDone { get; set; } = false;
}