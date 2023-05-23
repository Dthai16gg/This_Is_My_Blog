using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Configurations
{
    using DATA.Models;

    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CommentAriticleConfiguration : IEntityTypeConfiguration<CommentAriticle>
    {
        public void Configure(EntityTypeBuilder<CommentAriticle> builder)
        {
            builder.ToTable("CommentAriticles");
            builder.HasKey(x => x.Id);
            builder.HasOne(x => x.Article).WithMany(x => x.CommentAriticles).HasForeignKey(x => x.ArticleId);
            builder.HasOne(x => x.Comment).WithMany(x => x.CommentAriticles).HasForeignKey(x => x.CommentId);
        }
    }
}
