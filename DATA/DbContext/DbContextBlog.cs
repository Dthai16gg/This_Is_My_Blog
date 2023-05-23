namespace DATA.DbContext;

using System.Reflection;

using DATA.Models;

using Microsoft.EntityFrameworkCore;

public class DbContextBlog : DbContext
{
    public DbContextBlog()
    {
    }

    public DbContextBlog(DbContextOptions options)
        : base(options)
    {
    }

    public DbSet<Ad> Ad { get; set; }

    public DbSet<Article> Article { get; set; }

    public DbSet<Article_Category> Article_Category { get; set; }

    public DbSet<Article_Tag> Article_Tag { get; set; }

    public DbSet<Author> Author { get; set; }

    public DbSet<Category> Category { get; set; }

    public DbSet<Comment> Comment { get; set; }

    public DbSet<ImageArticle> ImageArticle { get; set; }

    public DbSet<Role> Role { get; set; }

    public DbSet<Subscriber> Subscriber { get; set; }

    public DbSet<Subscription> Subscription { get; set; }

    public DbSet<Tag> Tag { get; set; }

    public DbSet<User> User { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Data Source=DTHAI16GG\\SQLEXPRESS;Initial Catalog = BlogServer;Integrated Security=True;Trust Server Certificate=True");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}