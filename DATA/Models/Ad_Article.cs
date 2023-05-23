namespace DATA.Models;

public class Ad_Article
{
    public virtual Ad Ad { get; set; }

    public Guid AdId { get; set; }

    public virtual Article Article { get; set; }

    public Guid ArticleId { get; set; }

    // 1 bài viết có nhiều quảng cáo và 1 quảng cáo thêm vào nhiều bài viết
    public Guid Id { get; set; }
}