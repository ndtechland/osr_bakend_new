using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class Broker
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Mobile { get; set; }
        public string? PanNo { get; set; }
        public string? AdhaarNo { get; set; }
        public string? UserId { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? Email { get; set; }
    }
}
