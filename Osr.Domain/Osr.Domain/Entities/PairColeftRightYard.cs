using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class PairColeftRightYard
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public double CoLeft { get; set; }
        public double CoRight { get; set; }
    }
}
