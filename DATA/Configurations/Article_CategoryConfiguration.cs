namespace DATA.Configurations;

using DATA.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class Article_CategoryConfiguration : IEntityTypeConfiguration<Article_Category>
{
    public void Configure(EntityTypeBuilder<Article_Category> builder)
    {
        builder.ToTable("Article_Categories");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Article).WithMany(x => x.Article_Categories).HasForeignKey(x => x.ArticleId);
        builder.HasOne(x => x.Category).WithMany(x => x.Article_Categories).HasForeignKey(x => x.CategoryId);
    }
}