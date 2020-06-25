using System;
using System.Collections.Generic;
using System.Text;

namespace Facebook.Common.DTO
{
    public class PostDTO
    {
        public string PostText { get; set; }

        public DateTime SendTime { get; set; }

        public UserDTO User { get; set; }
    }
}
