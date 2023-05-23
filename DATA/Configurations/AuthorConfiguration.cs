namespace DATA.Configurations;

using DATA.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.ToTable("Authors");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
        builder.Property(x => x.Status).IsRequired();

        // 1 Author - N Article
        builder.HasMany(x => x.Articles).WithOne(x => x.Author).HasForeignKey(x => x.AuthorId);

        // 1 author -1 user
        builder.HasOne(x => x.User).WithOne(x => x.Author).HasForeignKey<Author>(x => x.UserId);
    }
}