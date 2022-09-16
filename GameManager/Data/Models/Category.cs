using System.ComponentModel.DataAnnotations;
namespace GameManager.Models;

public class Category
{
    [Key] public int Id { get; set; }
    public string Name { get; set; }
    public Users Owner { get; set; }
    public virtual ICollection<Object> Object { get; set; }

    public ICollection<CategoryClosure> Ancestors { get; set; }
    public ICollection<CategoryClosure> Descendants { get; set; }
}