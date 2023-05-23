namespace DATA.Models;

using System.ComponentModel.DataAnnotations.Schema;

public class User
{
    public virtual Author Author { get; set; }

    public List<CommentUser> CommentUser { get; set; }

    public string Email { get; set; }

    public Guid Id { get; set; }

    public string Name { get; set; }

    public string Password { get; set; }

    public DateTime RegistrationDate { get; set; }

    public Guid RoleId { get; set; }

    [ForeignKey("RoleType")]
    public virtual Role Roles { get; set; }

    public int Status { get; set; }

    public List<Subscription> Subscriptions { get; set; }

    public string UserName { get; set; }
}