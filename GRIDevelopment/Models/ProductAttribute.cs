using System.ComponentModel.DataAnnotations;

namespace GRIDevelopment.Models
{
    public class ProductAttribute
    {
        [Key]
        public int AttributeId { get; set; }
        [Required]
        [StringLength(20)]
        public String Key  { get; set; }
        [Required]
        [StringLength(10)]
        public String Value { get; set; }
        
    }
}
