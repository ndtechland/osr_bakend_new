using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class IncomeWallet
    {
        public int Id { get; set; }
        public double Amount { get; set; }
        public DateTime UpdateDate { get; set; }
        public int UserId { get; set; }
        public bool IsPaid { get; set; }
        public string? TransactionType { get; set; }
        public string? IncomeType { get; set; }
        public int? ChildId { get; set; }
    }
}
