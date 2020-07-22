using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SolarCoffee.Data.Models
{
    public class Product
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        [MaxLength(70)]
        public string Name { get; set; }
        [MaxLength(150)]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsTaxable { get; set; }
        public bool IsArchived { get; set; }
    }
}
