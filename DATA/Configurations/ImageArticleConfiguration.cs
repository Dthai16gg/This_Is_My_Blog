namespace DATA.Configurations;

using DATA.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ImageArticleConfiguration : IEntityTypeConfiguration<ImageArticle>
{
    public void Configure(EntityTypeBuilder<ImageArticle> builder)
    {
        builder.ToTable("ImageArticles");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Article).WithMany(x => x.Image_Article).HasForeignKey(x => x.ArticleId);
    }
}