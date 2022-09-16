using GameManager.Contexts;
using GameManager.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GameManager.DataHandlers;

public class CategoryHandler
{
    public static void EnsureStartingCategoryExists()
    {
        if (!CategoryExists("Starting"))
        {
            var admin = UsersHandler.GetByName("admin");

            using var context = new GameManagerContext();
            var nc = new Category {Name = "Starting", Owner = admin};
            context.Categories.Attach(nc);
            var c = context.Categories.Add(nc);

            context.CategoryClosures.Add(new CategoryClosure {Ancestor = c.Entity, Descendant = c.Entity});
            context.SaveChanges();
        }

        if (!ClosureExists("Starting", "Starting"))
        {
            var c = GetByName("Starting");
            using var context = new GameManagerContext();
            var a = new CategoryClosure {Ancestor = c, Descendant = c, Depth = 0};
            context.CategoryClosures.Attach(a);
            context.CategoryClosures.Add(a);
            context.SaveChanges();
        }
    }

    public static void AddCategory(string name, string parent, User owner)
    {
        var parentEntity = GetByName(parent);


        using var context = new GameManagerContext();
        var category = new Category {Name = name, Owner = owner};
        context.Attach(owner);
        context.Attach(parentEntity);
        var c = context.Categories.Add(category);
        context.SaveChanges();

        if (parentEntity != null)
            context.Database.ExecuteSqlRaw(
                "INSERT INTO CategoryClosures(AncestorId, DescendantId, Depth) SELECT AncestorId,{0},Depth+1 FROM CategoryClosures WHERE DescendantId = {1} UNION ALL SELECT {2},{3},{4}",
                c.Entity.Id, parentEntity.Id, c.Entity.Id, c.Entity.Id, 0);
        context.SaveChanges();
    }

    public static List<Category>? GetChildren(Category category)
    {
        using var context = new GameManagerContext();

        var a = context.Categories.FromSqlRaw(
                "SELECT * FROM CategoryClosures AS cp JOIN Categories AS c ON c.Id=cp.DescendantID WHERE cp.AncestorId = {0} and Depth = 1",
                category.Id)
            .ToList();
        return a;
    }

    public static List<Category> GetAll()
    {
        using var context = new GameManagerContext();
        return context.Categories.ToList();
    }

    public static List<Category> GetTree(Category category)
    {
        using var context = new GameManagerContext();

        var a = context.Categories.FromSqlRaw(
            "SELECT * FROM CategoryClosures AS cp JOIN Categories AS c ON c.Id=cp.DescendantID WHERE cp.AncestorId = {0} and Name!={1}",
            category.Id, category.Name).ToList().OrderBy(a => a.Descendants).ToList();


        return a;
    }

    public static Category? GetParent(Category category)
    {
        using var context = new GameManagerContext();
        var a = context.Categories.FromSqlRaw(
            "SELECT  * FROM Categories c  JOIN CategoryClosures  t ON c.Id=t.AncestorId WHERE t.DescendantId= {0} AND Depth=1",
            category.Id).ToList().FirstOrDefault(defaultValue: null);

        return a;
    }


    public static bool ClosureExists(string name1, string name2)
    {
        using var context = new GameManagerContext();
        if (!context.CategoryClosures.Any()) return false;
        var g = context.CategoryClosures
            .First(x => x.Ancestor.Name.Equals(name1) && x.Descendant.Name.Equals(name2));

        return g != null;
    }

    public static void DeleteCategory(Category category)
    {
        using var context = new GameManagerContext();
        context.Remove(category);
        context.SaveChanges();
    }

    public static bool CategoryExists(string name)
    {
        using var context = new GameManagerContext();
        if (!context.Categories.Any()) return false;
        return context.Categories.Single(x => x.Name.Equals(name)) != null;
    }

    public static Category? GetByName(string name)
    {
        using var context = new GameManagerContext();
        var cat = context.Categories.SingleOrDefault(x => x.Name.Equals(name));
        return cat;
    }
}