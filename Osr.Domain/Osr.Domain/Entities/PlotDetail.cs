using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class PlotDetail
    {
        public int Id { get; set; }
        public int SiteMasterId { get; set; }
        public string PlotNumber { get; set; } = null!;
        public string? TotalArea { get; set; }
        public int? PlotId { get; set; }
        public string? Status { get; set; }
        public string? PlotType1 { get; set; }
        public string? PlotIdPrefix { get; set; }
        public string? PlotNumber2 { get; set; }
        public string? Size2 { get; set; }
        public string? PlotNumberShop2 { get; set; }
        public string? ShopSize2 { get; set; }
    }
}
