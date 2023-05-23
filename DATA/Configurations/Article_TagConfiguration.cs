namespace DATA.Configurations;

using DATA.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class Article_TagConfiguration : IEntityTypeConfiguration<Article_Tag>
{
    public void Configure(EntityTypeBuilder<Article_Tag> builder)
    {
        builder.ToTable("Article_Tags");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Article).WithMany(x => x.Article_Tags).HasForeignKey(x => x.ArticleId);
        builder.HasOne(x => x.Tag).WithMany(x => x.Article_Tags).HasForeignKey(x => x.TagId);
    }
}