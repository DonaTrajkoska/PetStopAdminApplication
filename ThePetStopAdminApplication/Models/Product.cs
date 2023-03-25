using System;
using System.ComponentModel.DataAnnotations;

namespace ThePetStopAdminApplication.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductImage { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public double ProductPrice { get; set; }
        [Required]
        public string ProductCategory { get; set; }
        [Required]
        public string ProductAnimal { get; set; }
    }
}
