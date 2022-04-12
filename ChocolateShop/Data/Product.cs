using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChocolateShop.Data
{
    
    public class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public TypeFood Type { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}
