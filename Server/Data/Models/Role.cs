﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LyteChat.Server.Data.Models
{
    public class Role: IdentityRole<Guid>
    {
        public const string Admin = "Admin";
        public const string AuthenticatedUser = "AuthenticatedUser";
        public const string AnonymousUser = "AnonymousUser";
    }
}
