using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace GameManager.Data.Models;

public class User
{
    [Key] public int Id { get; set; }
    [NotNull] public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }

    [ForeignKey("role")] public Role? Role { get; set; }
}