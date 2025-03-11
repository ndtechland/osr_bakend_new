using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class OfferReward
    {
        public int Id { get; set; }
        public string? Uid { get; set; }
        public string? Reward { get; set; }
        public string? TodayDate { get; set; }
        public bool? IsGiven { get; set; }
    }
}
