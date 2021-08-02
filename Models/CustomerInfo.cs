using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GoWMS.Server.Models
{
    public class CustomerInfo
    {
        public int CustomerId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string City { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Gender { get; set; }

        public decimal Qty { get; set; }
    }
}
