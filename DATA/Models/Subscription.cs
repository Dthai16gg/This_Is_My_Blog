namespace DATA.Models;

public class Subscription
{
    public virtual Category Category { get; set; }

    public Guid CategoryId { get; set; }

    public Guid Id { get; set; }

    public DateTime RegistrationDate { get; set; }

    public int Status { get; set; }

    public virtual Subscriber Subscriber { get; set; }

    public Guid SubscriberId { get; set; }

    public virtual User User { get; set; }

    public Guid UserID { get; set; }
}