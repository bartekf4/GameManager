namespace GameManager.Data.Models;

public class ObjectProperty
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Value { get; set; }
    public bool IsCore { get; set; }
    public virtual Object Object { get; set; }

    public override string ToString()
    {
        return "Name: " + Name + " Value: " + Value + " Is key? " + IsCore;
    }
}