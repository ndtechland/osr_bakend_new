using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class BookPlotForAdmin
    {
        public int Id { get; set; }
        public int? SiteId { get; set; }
        public int? PlotId { get; set; }
        public string? Amount { get; set; }
        public string? Mobile { get; set; }
        public string? Name { get; set; }
        public DateTime? Date { get; set; }
    }
}
