using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class SlipNew
    {
        public int Id { get; set; }
        public long RecieptNo { get; set; }
        public DateTime CreateDate { get; set; }
        public string CustomerName { get; set; } = null!;
        public string FatherName { get; set; } = null!;
        public int PlotDetailId { get; set; }
        public string MobileNumber { get; set; } = null!;
        public double Yards { get; set; }
        public double Rate { get; set; }
        public double Commision { get; set; }
        public double Total { get; set; }
        public double Advance { get; set; }
        public int NoOfEmi { get; set; }
        public double PerMonthAmount { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime RegistryDate { get; set; }
        public string ModeOfPayment { get; set; } = null!;
        public string? ChequeNumber { get; set; }
        public string? BankName { get; set; }
        public string? Description { get; set; }
        public DateTime? Dob { get; set; }
        public int? ParentId { get; set; }
        public string? SponsorId { get; set; }
        public int? AdminLoginId { get; set; }
        public bool? IsLeft { get; set; }
        public int? SpillSponsorId { get; set; }
        public string? Title { get; set; }
        public string? Status { get; set; }
        public string? MotherName { get; set; }
        public string? Gender { get; set; }
        public string? AccountNumber { get; set; }
        public string? PanNumber { get; set; }
        public string? NomineeName { get; set; }
        public string? OfficeNumber { get; set; }
        public string? PermanentAddress { get; set; }
        public string? PresentAddress { get; set; }
        public string? Email { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool HasCompletePayout { get; set; }
        public DateTime? ActiveDate { get; set; }
        public bool? OffPayHasComplete { get; set; }
        public int? LevelId { get; set; }
        public int? CommonId { get; set; }
        public int? AddPersonId { get; set; }
        public string? Post { get; set; }
        public string? PanFatherName { get; set; }
    }
}
