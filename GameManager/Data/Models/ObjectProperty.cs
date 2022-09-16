namespace GameManager.Models;

public class ObjectProperty
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Value { get; set; }
    public bool IsCore { get; set; }
    public virtual Object Object { get; set; }
}