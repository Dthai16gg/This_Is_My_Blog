namespace DATA.Models;

public class Author
{
    public List<Article> Articles { get; set; }

    public string Description { get; set; }

    public Guid Id { get; set; }

    public string Image { get; set; }

    public string Name { get; set; }

    public int Status { get; set; }

    public virtual User User { get; set; }

    public Guid UserId { get; set; }
}