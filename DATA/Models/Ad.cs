namespace DATA.Models; 

public class Ad
{
    // Một bài viết có nhiều ad 
    public List<Ad_Article> Ad_Article { get; set; }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public int Status { get; set; }

    public string Url { get; set; } // Url of the image
}