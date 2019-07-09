using System;
using System.Collections.Generic;
using System.Text;
using DomainModels;
using Microsoft.EntityFrameworkCore;


namespace DataLayer
{
    public class HospitalityContext : DbContext
    {
        public HospitalityContext(DbContextOptions options)
        : base(options)
        {

        }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Staff> StaffSet { get; set; }
        public DbSet<RoleStaff> RolesStaffSet { get; set; }
    }
}
