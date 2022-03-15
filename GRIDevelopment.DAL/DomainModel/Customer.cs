using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GRIDevelopment.DAL.DomainModel
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Customer Name is required")]
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }

        [Required(ErrorMessage = "Customer Address is required")]
        public string CusAddress {get; set;}

        [Required(ErrorMessage = "Customer Zip Code is required")]
        public int CusZipCode {get; set;}

        [Required(ErrorMessage = "Customer Contact is required")]
        [StringLength(10, ErrorMessage = "Must be a valid contact number", MinimumLength = 10)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
        public string CusContact { get; set; }

    }
}
