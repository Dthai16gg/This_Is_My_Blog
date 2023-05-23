namespace DATA.Models;

public class Comment
{
    // và comment n-n voi article
    public List<CommentAriticle> CommentAriticles { get; set; }

    // user n-n voi comment
    public List<CommentUser> CommentUser { get; set; }

    public string Content { get; set; }

    public Guid Id { get; set; }

    public int Status { get; set; } // 0: draft, 1: published, 2: deleted
}