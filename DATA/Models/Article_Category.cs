namespace DATA.Models;

public class Article_Category
{
    public virtual Article Article { get; set; }

    public Guid ArticleId { get; set; }

    public virtual Category Category { get; set; }

    public Guid CategoryId { get; set; }

    public Guid Id { get; set; }
}