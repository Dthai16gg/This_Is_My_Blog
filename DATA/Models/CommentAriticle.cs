using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Models
{
    public class CommentAriticle
    {
        public Guid Id { get; set; }
        //bang comment n-n voi article
        public virtual Article Article { get; set; }
        public Guid ArticleId { get; set; }
        public virtual Comment Comment { get; set; }
        public Guid CommentId { get; set; }
    }
}
