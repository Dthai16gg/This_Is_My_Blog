namespace DATA.Models;

public class CommentAriticle
{
    // bang comment n-n voi article
    public virtual Article Article { get; set; }

    public Guid ArticleId { get; set; }

    public virtual Comment Comment { get; set; }

    public Guid CommentId { get; set; }

    public Guid Id { get; set; }
}