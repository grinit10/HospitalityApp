using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DomainModels
{
    public class Hotel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Staff> Staff { get; set; }
    }
}
