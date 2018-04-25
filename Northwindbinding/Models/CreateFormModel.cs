using NorthwindLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Northwindbinding.Models
{
    public class CreateFormModel
    {
        public List<Suppliers> Suppliers { get; set; } = new List<Suppliers>();
        public List<Categories> Categories { get; set; } = new List<Categories>();
    }
}
