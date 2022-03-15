using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GRIDevelopment.DAL.DomainModel
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product Name is required")]
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }

        [Required(ErrorMessage = "Application type is required")]
        public string Application { get; set; }

        
        public string RimSize { get; set; }

        public string TubeSize { get; set; }
    }
}
