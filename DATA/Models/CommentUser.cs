using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Models
{
    public class CommentUser
    {
        public Guid Id { get; set; }
        //bang comment n-n voi user
        public virtual User User { get; set; }
        public Guid UserId { get; set; }
        public virtual Comment Comment { get; set; }
        public Guid CommentId { get; set; }
    }
}
