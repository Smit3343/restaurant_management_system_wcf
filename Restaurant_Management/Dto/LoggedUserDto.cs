﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_Management.Dto
{
    public class LoggedUserDto
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}