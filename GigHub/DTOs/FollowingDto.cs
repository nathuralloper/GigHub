﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GigHub.DTOs
{
    public class FollowingDto
    {
        public string FolloweeId { get; set; }
        public string FollowerId { get; set; }
    }
}