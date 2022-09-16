using System.ComponentModel.DataAnnotations;

namespace GameManager.Data.Models;

public class Category
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public User Owner { get; set; }
    public virtual ICollection<Object> Object { get; set; }

    public ICollection<CategoryClosure> Ancestors { get; set; }
    public ICollection<CategoryClosure> Descendants { get; set; }

    public Role? EditPermission { get; set; }
    public Role? AddPermission { get; set; }
}