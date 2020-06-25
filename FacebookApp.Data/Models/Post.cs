using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookApp.Data.Models
{
    public class Post
    {
        public int PostId { get; set; }

        public string PostText { get; set; }

        public DateTime SendTime { get; set; }

        public virtual ICollection<Like> Likes { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public int UserId { get; set; } //nullable olmasını önler
        public User User { get; set; } //Fk

    }
}
