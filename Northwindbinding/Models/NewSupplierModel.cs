using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Northwindbinding.Models
{
    public class NewSupplierModel
    {   [Required]
        public String CompanyName { get; set; }
        [Required]
        public String ContactName { get; set; }
        [Required]
        public String City { get; set; }

        public int? PostalCode { get; set; }
        public String  Country { get; set; }
    }
}
