using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class PromoIncomeDetail
    {
        public int Id { get; set; }
        public int RemainingQuantity { get; set; }
        public int? UserDetailId { get; set; }
        public double Amount { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}
