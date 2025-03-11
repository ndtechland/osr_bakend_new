using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class SiteMaster
    {
        public int Id { get; set; }
        public string SiteName { get; set; } = null!;
        public string SiteAddress { get; set; } = null!;
        public string? SiteDescription { get; set; }
    }
}
