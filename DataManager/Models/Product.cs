using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DataManager.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Price { get; set; }


        public int ManufacturerId { get; set; }
        public Manufacturer Manufacturer { get; set; }
    }
}
