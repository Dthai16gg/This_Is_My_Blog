namespace DATA.Models;

using System.ComponentModel.DataAnnotations.Schema;

public class Comment
{
    public string Content { get; set; }

    public Guid Id { get; set; }

    public int Status { get; set; } // 0: draft, 1: published, 2: deleted

    //user n-n voi comment
    public List<CommentUser> CommentUser { get; set; }
    //và comment n-n voi article
    public List<CommentAriticle> CommentAriticles { get; set; }

}