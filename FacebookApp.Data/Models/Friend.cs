﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookApp.Data.Models
{
    public class Friend
    {
        public int Id { get; set; }

        public int RequestedId { get; set; }

        public int UserId { get; set; } 

        public User User { get; set; }
    }
}
