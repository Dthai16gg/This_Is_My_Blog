namespace DATA.Models;

public class Subscriber
{
    public string Email { get; set; }

    public Guid Id { get; set; }

    public DateTime RegistrationDate { get; set; }

    public int Status { get; set; }

    public List<Subscription> Subscriptions { get; set; }
}