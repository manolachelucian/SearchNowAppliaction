using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchNow.src.objects.forum.comment
{
    public class CommentItem
    {
        public int CommentId { get; set; }
        public string CommentInfo { get; set; }

        public CommentItem(int commentId, string commentInfo)
        {
            CommentId = commentId;
            CommentInfo = commentInfo;
        }

        public override string ToString()
        {
            return CommentInfo;
        }
    }
}
