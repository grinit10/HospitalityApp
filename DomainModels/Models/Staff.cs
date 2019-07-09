using System;
using System.Collections.Generic;
using System.Text;

namespace DomainModels
{
    public class Staff
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Hotel Hotel { get; set; }
        public Guid HotelId { get; set; }
        public ICollection<RoleStaff> RoleStaff { get; set; }
    }
}
