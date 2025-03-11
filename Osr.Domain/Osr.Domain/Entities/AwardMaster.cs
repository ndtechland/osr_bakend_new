using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class AwardMaster
    {
        public int Id { get; set; }
        public int LeftYards { get; set; }
        public int RightYards { get; set; }
        public string Award { get; set; } = null!;
        public int Level { get; set; }
    }
}
