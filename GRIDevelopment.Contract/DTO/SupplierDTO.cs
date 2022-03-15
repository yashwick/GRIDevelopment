using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GRIDevelopment.Contract.DTO
{
    public class SupplierDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Supplier Name is required")]
        public string SupplierName { get; set; }
        public string SupAddress { get; set; }

        [StringLength(10,ErrorMessage = "Must be a valid contact number",MinimumLength = 10)]
        public string SupContact { get; set; }
    }
}
