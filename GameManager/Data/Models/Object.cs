namespace GameManager.Data.Models;

public class Object
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsRemoved { get; set; }
    public byte[] Photo { get; set; }
    public virtual User Owner { get; set; }
    public virtual Category Category { get; set; }

    public virtual ICollection<ObjectProperty> GameObjectProperties { get; set; }
}