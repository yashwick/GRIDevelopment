using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GRIDevelopment.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public String Application { get; set; }
        [Required]
        
        public String Rim_Size { get; set; }
        public String Tire_Size { get; set; }
        public String Pattern { get; set; }

        public decimal Price { get; set; }
        
        public int Quantity { get; set; }
        [Required]
        
        public DateTime CreateDateTime { get; set; } = DateTime.Now;
    }
}
