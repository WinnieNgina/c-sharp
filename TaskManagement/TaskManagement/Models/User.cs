﻿using Microsoft.AspNetCore.Identity;
using System.Drawing;

namespace TaskManagement.Models
{
    public class User:IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
