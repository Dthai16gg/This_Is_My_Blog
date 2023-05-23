namespace DATA.Configurations;

using DATA.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class Ad_ArticleConfiguration : IEntityTypeConfiguration<Ad_Article>
{
    public void Configure(EntityTypeBuilder<Ad_Article> builder)
    {
        builder.ToTable("Ad_Articles");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.Article).WithMany(x => x.Ad_Articles).HasForeignKey(x => x.ArticleId);
        builder.HasOne(x => x.Ad).WithMany(x => x.Ad_Article).HasForeignKey(x => x.AdId);
    }
}