using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class ParingCalculation
    {
        public int Id { get; set; }
        public int? UserDetailId { get; set; }
        public int PairedId { get; set; }
        public int? ParentId { get; set; }
        public DateTime? GenerateDate { get; set; }
    }
}
