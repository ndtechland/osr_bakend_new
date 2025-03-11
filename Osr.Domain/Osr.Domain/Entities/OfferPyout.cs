using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class OfferPyout
    {
        public int Id { get; set; }
        public string? Uid { get; set; }
        public string? Uname { get; set; }
        public string? IncomeId { get; set; }
        public int? IncomeLavel { get; set; }
        public int? Income { get; set; }
        public string? TodayDate { get; set; }
        public bool? IsShow { get; set; }
    }
}
