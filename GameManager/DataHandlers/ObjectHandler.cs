using System.Data.Entity;
using System.Text.RegularExpressions;
using GameManager.Contexts;
using GameManager.Data.Models;
using Object = GameManager.Data.Models.Object;

namespace GameManager.DataHandlers;

public class ObjectHandler
{
    public static List<User> GetAuthors()
    {
        using var context = new GameManagerContext();
        return context.Objects.Select(x => x.Owner).Distinct().ToList();
    }

    public static int Count()
    {
        using var context = new GameManagerContext();
        return context.Objects.Count();
    }

    public static List<Object> GetBest(int howMany)
    {
        using var context = new GameManagerContext();
        // var objects = context.Objects.Include(x => x.GameObjectProperties)
        //     .Select(x => x.GameObjectProperties.Where(y => y.IsCore == true));

        var o = context.ObjectProperties.Where(x => x.IsCore == true).Include(y => y.Object)
            .Select(y => y.Object).ToList().GetRange(0, howMany);
        return o;
    }

    public static List<Object> GetObjects(string name)
    {
        var re = new Regex(name);
        using var context = new GameManagerContext();
        return context.Objects.Where(x => re.IsMatch(x.Name)).ToList();
    }

    public static List<Object> GetAllObjects()
    {
        using var context = new GameManagerContext();
        // return context.Objects.ToList();
        return context.Objects.Include(b => b.Category).ToList();
    }

    public static List<Object> GetObjects(List<Category> categories, string name)
    {
        var re = new Regex(name, RegexOptions.IgnorePatternWhitespace | RegexOptions.IgnoreCase);

        var objects = GetObjects(categories).Where(x => re.IsMatch(x.Name)).ToList();
        return objects;
    }

    public static List<Object> GetObjects(List<Category> categories, string name, List<User> users)
    {
        var re = new Regex(name);

        using var context = new GameManagerContext();
        return context.Objects.Where(x => categories.Contains(x.Category) &&
                                          re.IsMatch(x.Name) &&
                                          users.Contains(x.Owner)).ToList();
    }

    public static List<Object> GetObjects(List<Category> categories)
    {
        var obj = GetAllObjects();
        obj = obj.Where(x => categories.Exists(y => y.Id == x.Category.Id)).ToList();


        return obj;
    }


    public static List<ObjectProperty> GetObjectsProperties(Object? obj)
    {
        if (obj == null) return null;

        using var context = new GameManagerContext();
        return context.ObjectProperties.Where(x => x.Object == obj).ToList();
    }

    public static Object Add(Category category,
        string name,
        User owner,
        byte[] photo,
        List<ObjectProperty> objectProperties)
    {
        var o = new Object {Category = category, Name = name, Owner = owner, Photo = photo};

        using var context = new GameManagerContext();
        context.Objects.Attach(o);
        context.Objects.Add(o);
        foreach (var property in objectProperties)
            context.ObjectProperties.Add(new ObjectProperty
                {IsCore = property.IsCore, Name = property.Name, Object = o, Value = property.Value});

        context.SaveChanges();


        return o;
    }
}