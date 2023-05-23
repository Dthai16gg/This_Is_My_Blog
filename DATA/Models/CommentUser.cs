namespace DATA.Models;

public class CommentUser
{
    public virtual Comment Comment { get; set; }

    public Guid CommentId { get; set; }

    public Guid Id { get; set; }

    // bang comment n-n voi user
    public virtual User User { get; set; }

    public Guid UserId { get; set; }
}