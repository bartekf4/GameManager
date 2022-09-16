using System.ComponentModel.DataAnnotations;

namespace GameManager.Data.Models;

public class Role
{
    [Key] public string Name { get; set; }

    public ICollection<User> Users { get; set; }

    public ICollection<Category> EditPermissions { get; set; }

    public ICollection<Category> AddPermissions { get; set; }

    public override string ToString()
    {
        return base.ToString();
    }
}