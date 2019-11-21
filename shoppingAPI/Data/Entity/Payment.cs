using System;
using System.ComponentModel.DataAnnotations;

namespace shoppingAPI.Data.Entity
{
    public class Payment
    {
        public int PaymentId { get; set; }

        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        [Required]
        public DateTime PaymentDay { get; set; } = DateTime.UtcNow.Date;

        [Required]
        public double Amount { get; set; }
    }
}