using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class UserAwardOneThirdPay
    {
        public int Id { get; set; }
        public int? SlipId { get; set; }
        public string? UserName { get; set; }
        public string? SponsorId { get; set; }
        public double? LeftYards { get; set; }
        public double? RightYards { get; set; }
        public string? TodayDate { get; set; }
    }
}
