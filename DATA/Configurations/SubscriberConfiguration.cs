namespace DATA.Configurations;

using DATA.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class SubscriberConfiguration : IEntityTypeConfiguration<Subscriber>
{
    public void Configure(EntityTypeBuilder<Subscriber> builder)
    {
        builder.ToTable("Subscribers");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Email).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Status).IsRequired();

        // subscriber 1-n subscription
        builder.HasMany(x => x.Subscriptions).WithOne(x => x.Subscriber).HasForeignKey(x => x.SubscriberId);
    }
}