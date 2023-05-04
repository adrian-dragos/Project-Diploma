﻿using Domain.Entities.Authorization;
using Domain.Entities.Common;

namespace Domain.Entities
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; } 
        public Role Role { get; set; }
    }
}
