using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class IncomeAndReward
    {
        public int Id { get; set; }
        public int LeftYards { get; set; }
        public int RightYards { get; set; }
        public double Amount { get; set; }
        public int Months { get; set; }
        public string? Reward { get; set; }
        public int Level { get; set; }
    }
}
