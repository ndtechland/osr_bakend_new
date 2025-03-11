using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class BrokerSite
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public int? PlotId { get; set; }
        public string? BookingAmount { get; set; }
        public string? CustomerName { get; set; }
        public string? Mobile { get; set; }
        public string? Area { get; set; }
        public string? Email { get; set; }
        public int? BrokerId { get; set; }
        public string? Status { get; set; }
    }
}
