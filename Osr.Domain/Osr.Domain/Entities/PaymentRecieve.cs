using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class PaymentRecieve
    {
        public int Id { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string? Amount { get; set; }
        public string? PaymentType { get; set; }
        public string? UserName { get; set; }
        public string? Status { get; set; }
    }
}
