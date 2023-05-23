namespace DATA.Models;

public class ImageArticle
{
    public virtual Article Article { get; set; }

    public Guid ArticleId { get; set; }

    public Guid Id { get; set; }

    public string Url { get; set; }
}