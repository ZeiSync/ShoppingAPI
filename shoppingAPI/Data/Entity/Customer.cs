using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace shoppingAPI.Data.Entity
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string ContactName { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string State { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string Country { get; set; }

        [Required]
        public int OrderTotal { get; set; }

        public string OrderPlace { get; set; }

        public IEnumerable<OrderDetail> OrderDetails { get; set; }

        public IEnumerable<Payment> Payments { get; set; }
    }
}