namespace DATA.Models;

public class Tag
{
    public List<Article_Tag> Article_Tags { get; set; }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public int Status { get; set; }
}