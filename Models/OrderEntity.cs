using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Comp1170mvc.Models
{
    public class OrderEntity
    {
        public string? Email { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? Province { get; set; }
        public string? PostalCode { get; set; }
        public string? Phone { get; set; }
        public string? OrderType { get; set; }
        public int NumberOfTickets { get; set; }
        public string? PaymentType { get; set; }
        public string? CardType { get; set; }
        public string? CardNumber { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYear { get; set; }
    }
}