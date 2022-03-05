using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRIDevelopment.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public String ProductName { get; set; }

        [ForeignKey("ProductAttribute")]
        public int AttributeIdFK { get; set; }
        public virtual ProductAttribute ProductAttribute { get; set; }  
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
