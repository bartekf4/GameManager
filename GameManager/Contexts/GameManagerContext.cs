using GameManager.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Object = GameManager.Data.Models.Object;

namespace GameManager.Contexts;

public class GameManagerContext : DbContext

{
    public DbSet<Category> Categories { get; set; }
    public DbSet<CategoryClosure> CategoryClosures { get; set; }
    public DbSet<Object> Objects { get; set; }
    public DbSet<ObjectProperty> ObjectProperties { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<User> Users { get; set; }


    public string DbPath { get; }


    public static void ConfigureServices(IServiceCollection services)
    {
        services.AddEntityFrameworkSqlite().AddDbContext<GameManagerContext>();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseSqlite(@"Data Source=" + @"..\..\..\GameMapol.db"
            // ,
            // options => { options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName); }
        );
        base.OnConfiguring(options);
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Object>().Navigation(e => e.Category).AutoInclude();


        modelBuilder.Entity<CategoryClosure>()
            .HasKey(c => new {c.AncestorId, c.DescendantId});


        modelBuilder.Entity<Category>()
            .HasMany(c => c.Ancestors)
            .WithOne(e => e.Ancestor);

        modelBuilder.Entity<Category>()
            .HasMany(c => c.Descendants)
            .WithOne(e => e.Descendant);

        modelBuilder.Entity<Role>().HasKey(x => x.Name);

        modelBuilder.Entity<Object>().HasKey(x => x.Id);

        modelBuilder.Entity<Role>().HasMany(x => x.Users).WithOne(x => x.Role).OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Role>().HasMany(x => x.AddPermissions).WithOne(x => x.AddPermission);
        modelBuilder.Entity<Role>().HasMany(x => x.EditPermissions).WithOne(x => x.EditPermission);
    }
}