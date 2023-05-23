namespace DATA.Models;

public class Article
{
    // Một bài viết có nhiều ad
    public List<Ad_Article> Ad_Articles { get; set; }

    public List<Article_Category> Article_Categories { get; set; }

    public List<Article_Tag> Article_Tags { get; set; }

    public virtual Author Author { get; set; }

    public Guid AuthorId { get; set; }

    public List<CommentAriticle> CommentAriticles { get; set; }

    public string Content { get; set; }

    public DateTime CreatedDate { get; set; }

    public Guid Id { get; set; }

    public List<ImageArticle> Image_Article { get; set; }

    public int Status { get; set; } // 0: draft, 1: published, 2: deleted 

    public string Title { get; set; }

    public int ViewCount { get; set; }
}