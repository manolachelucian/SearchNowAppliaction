using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchNow.src.objects.forum
{
    public class Forum
    {
        public int Id { get; set; }
        public string ForumName { get; set; }

        public string Description { get; set; }

        public string CreatedAt { get; set; }

        public string CreatedBy { get; set; }

    }
}
