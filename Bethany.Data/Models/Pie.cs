using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bethany.Data.Models
{
    public class Pie
    {
        public int PieId { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(150)]
        public string ShortDescription { get; set; }
        [Required, MaxLength(5000)]
        public string LongDescription { get; set; }
        public string AllergyInformation { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        [Required, MaxLength(200)]
        public string ImageUrl { get; set; }
        [Required, MaxLength(200)]

        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        [Required]
        public bool InStock { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [MaxLength(5000)]
        public string Notes { get; set; }
    }
}
