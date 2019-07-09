using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class Role
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public DateTime Duration { get; set; }
        public ICollection<RoleStaff> RoleStaff { get; set; } 
    }
}
