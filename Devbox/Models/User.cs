﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devbox.Models
{
    internal class User
    {
        public Guid Id { get; set; }
        public string Username { get; set; }
        public string ImageUrl { get; set; }
    }
}
