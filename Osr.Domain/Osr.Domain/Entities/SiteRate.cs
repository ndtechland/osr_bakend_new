using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class SiteRate
    {
        public int Id { get; set; }
        public int SiteMasterId { get; set; }
        public double Amount { get; set; }
        public double Rate { get; set; }
        public string? IsActive { get; set; }
    }
}
