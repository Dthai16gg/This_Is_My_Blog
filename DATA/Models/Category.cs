namespace DATA.Models;

public class Category
{
    public List<Article_Category> Article_Categories { get; set; }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public int Status { get; set; }

    public List<Subscription> Subscriptions { get; set; }
}