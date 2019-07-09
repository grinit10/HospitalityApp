using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class RoleStaff
    {
        public Guid Id { get; set; }
        public Role Role { get; set; }
        public Guid RoleId { get; set; }
        public Staff Staff { get; set; }
        public Guid StaffId { get; set; }
    }
}
