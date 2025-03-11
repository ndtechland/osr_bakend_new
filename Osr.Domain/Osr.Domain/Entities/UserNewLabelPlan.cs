using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class UserNewLabelPlan
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public string? UserLevel { get; set; }
    }
}
