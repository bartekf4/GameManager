using GameManager.Contexts;
using GameManager.Data.Models;

namespace GameManager.DataHandlers;

internal static class UsersHandler
{
    public static List<User> GetAllUsers()
    {
        using var context = new GameManagerContext();
        return context.Users.Where(x => !x.Username.Equals("admin") && !x.Username.Equals("guest")).ToList();
    }

    public static void UpdateRole(User user, Role role)
    {
        using var context = new GameManagerContext();
        context.Users.Find(user)!.Role = role;
        context.SaveChanges();
    }

    public static User AddUser(string username, string email, string password, string role)
    {
        var user = new User
            {Email = email, Password = Cryptography.Encrypt(password), Username = username, Role = null};

        using var context = new GameManagerContext();
        context.Database.EnsureCreated();
        context.Users.Add(user);
        context.SaveChanges();

        return user;
    }

    public static User? GetByName(string name)
    {
        using var context = new GameManagerContext();
        var user = context.Users.SingleOrDefault(x => x.Username.Equals(name));
        return user;
    }

    public static User? GetByEmail(string email)
    {
        using var context = new GameManagerContext();
        var user = context.Users.SingleOrDefault(x => x.Email.Equals(email));
        return user;
    }

    public static bool Exists(string name)
    {
        return GetByName(name) != null;
    }

    public static bool UpdateUser(string username, string newEmail, string currentPassword, string newPassword)
    {
        if (!Authenticate(username, currentPassword)) return false;

        var user = GetByName(username);
        if (user == null) return false;
        user.Email = newEmail;
        user.Password = newPassword;
        return true;
    }

    public static void AdminCheckIfExistsOrAdd()
    {
        if (Exists("admin")) return;
        if (!RolesHandler.Exists("admin")) RolesHandler.Add("admin");
        AddUser("admin", "admin", "admin", "admin");
    }

    public static void GuestCheckIfExistsOrAdd()
    {
        if (Exists("guest")) return;
        if (!RolesHandler.Exists("guest")) RolesHandler.Add("guest  ");
        AddUser("guest", "guest", "guest", "guest");
    }


    public static bool Authenticate(string name, string password)
    {
        if (!Exists(name)) return false;
        var user = GetByName(name);
        return user!.Username.Equals(name) && Cryptography.Encrypt(password).Equals(user.Password);
    }

    public static User AddUser(User user)
    {
        using var context = new GameManagerContext();
        context.Database.EnsureCreated();
        context.Users.Add(user);
        context.SaveChanges();
        return user;
    }
}