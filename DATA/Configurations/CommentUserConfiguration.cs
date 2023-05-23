namespace DATA.Configurations;

using DATA.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class CommentUserConfiguration : IEntityTypeConfiguration<CommentUser>
{
    public void Configure(EntityTypeBuilder<CommentUser> builder)
    {
        builder.ToTable("CommentUsers");
        builder.HasKey(x => x.Id);
        builder.HasOne(x => x.User).WithMany(x => x.CommentUser).HasForeignKey(x => x.UserId);
        builder.HasOne(x => x.Comment).WithMany(x => x.CommentUser).HasForeignKey(x => x.CommentId);
    }
}