namespace DATA.Configurations;

using DATA.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SubscriptionConfiguration : IEntityTypeConfiguration<Subscription>
{
    public void Configure(EntityTypeBuilder<Subscription> builder)
    {
        builder.ToTable("Subscriptions");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Status).IsRequired();
        builder.HasOne(x => x.Category).WithMany(x => x.Subscriptions).HasForeignKey(x => x.CategoryId);
        builder.HasOne(x => x.User).WithMany(x => x.Subscriptions).HasForeignKey(x => x.UserID);
    }
}