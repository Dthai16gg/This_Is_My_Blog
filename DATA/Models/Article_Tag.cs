namespace DATA.Models;

public class Article_Tag
{
    public virtual Article Article { get; set; }

    public Guid ArticleId { get; set; }

    public Guid Id { get; set; }

    public virtual Tag Tag { get; set; }

    public Guid TagId { get; set; }
}