using System;
using System.Collections.Generic;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class NewPlan
    {
        public int Id { get; set; }
        public int? RecieptNo { get; set; }
        public string? CreateDate { get; set; }
        public string? CustomerName { get; set; }
        public string? FatherName { get; set; }
        public int? PlotDetailId { get; set; }
        public string? MobileNumber { get; set; }
        public string? Yards { get; set; }
        public string? Rate { get; set; }
        public string? Commision { get; set; }
        public string? Total { get; set; }
        public string? Advance { get; set; }
        public int? NoOfEmi { get; set; }
        public string? PerMonthAmount { get; set; }
        public string? DueDate { get; set; }
        public string? RegistryDate { get; set; }
        public string? ModeOfPayment { get; set; }
        public string? ChequeNumber { get; set; }
        public string? BankName { get; set; }
        public string? Description { get; set; }
        public string? Dob { get; set; }
        public int? ParentId { get; set; }
        public string? SponsorId { get; set; }
        public int? AdminLoginId { get; set; }
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
        public DateTime? ActiveDate { get; set; }
        public int? SiteMasterId { get; set; }
    }
}
