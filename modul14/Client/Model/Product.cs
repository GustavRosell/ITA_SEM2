using System;
using System.ComponentModel.DataAnnotations;

namespace modul14.Client.Model
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must be less than 50 characters.")]
        public string? Name { get; set; }

        [Required]
        [Range(1,int.MaxValue, ErrorMessage = "Price must be positive")]
        public int? Price { get; set; }

        [Required]
        public string? Description { get; set; }

        public bool IsPublished { get; set; }

        public DateTime PublishedDate { get; set; } = DateTime.Now;
    }
}

