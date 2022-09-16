using GameManager.Contexts;
using GameManager.Data.Models;

namespace GameManager.DataHandlers;

public class RolesHandler
{
    public static void Delete(Role role)
    {
        using var context = new GameManagerContext();
        context.Roles.Remove(role);
        context.SaveChanges();
        // TODO remove also associated users
    }


    public static void Add(Role role)
    {
        using var context = new GameManagerContext();
        context.Roles.Add(role);
        context.SaveChanges();
    }


    public static Role? GetUsersRole(User user)
    {
        using var context = new GameManagerContext();

        return context.Roles.Where(x => user.Role != null && x.Name.Equals(user.Role.Name)).ToList()
            .FirstOrDefault(defaultValue: null);
    }


    public static List<Role> GetAllRoles()
    {
        using var context = new GameManagerContext();

        return context.Roles.ToList();
    }

    public static Role Add(string name)
    {
        var role = new Role {Name = name};
        using var context = new GameManagerContext();
        context.Roles.Add(role);
        context.SaveChanges();
        return role;
    }

    public static bool Exists(string name)
    {
        return GetByName(name) != null;
    }

    public static Role? GetByName(string name)
    {
        using var context = new GameManagerContext();
        if (context.Roles.Any()) return null;
        // var role = context.Roles.SingleOrDefault(x => x.Name.Equals(name), defaultValue: null);
        var role = context.Roles.FirstOrDefault(x => x.Name.Equals(name));
        return role;
    }
}