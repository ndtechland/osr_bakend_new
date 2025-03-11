using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class AwardCalculation
    {
        public int Id { get; set; }
        public int? UserDetailId { get; set; }
        public int CalculatedId { get; set; }
        public int? ParentId { get; set; }
        public DateTime? GenerateDate { get; set; }
    }
}
