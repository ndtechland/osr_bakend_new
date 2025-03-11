using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class UserLevel
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? ULevel { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int CoLeft { get; set; }
        public int CoRight { get; set; }
        public string? LabelName { get; set; }
    }
}
