using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class Emi
    {
        public int Id { get; set; }
        public int SlipId { get; set; }
        public double EmiAmount { get; set; }
        public double Fine { get; set; }
        public DateTime? EmiDate { get; set; }
        public DateTime NextEmiDate { get; set; }
        public string Mop { get; set; } = null!;
        public string? ChequeNo { get; set; }
        public string? BankName { get; set; }
        public long RecieptNumber { get; set; }
        public string? Description { get; set; }
        public double Commision { get; set; }
        public DateTime? ActiveDate { get; set; }
    }
}
