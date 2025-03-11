using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Osr.Domain.Osr.Domain.Entities
{
    public partial class osr_newContext : DbContext
    {
        public osr_newContext()
        {
        }

        public osr_newContext(DbContextOptions<osr_newContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AwardCalculation> AwardCalculations { get; set; } = null!;
        public virtual DbSet<AwardMaster> AwardMasters { get; set; } = null!;
        public virtual DbSet<BannerImage> BannerImages { get; set; } = null!;
        public virtual DbSet<BookPlotForAdmin> BookPlotForAdmins { get; set; } = null!;
        public virtual DbSet<Broker> Brokers { get; set; } = null!;
        public virtual DbSet<BrokerSite> BrokerSites { get; set; } = null!;
        public virtual DbSet<Emi> Emis { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Gallery> Galleries { get; set; } = null!;
        public virtual DbSet<IncomeAndReward> IncomeAndRewards { get; set; } = null!;
        public virtual DbSet<IncomeWallet> IncomeWallets { get; set; } = null!;
        public virtual DbSet<Level> Levels { get; set; } = null!;
        public virtual DbSet<NewPlan> NewPlans { get; set; } = null!;
        public virtual DbSet<OfferPyout> OfferPyouts { get; set; } = null!;
        public virtual DbSet<OfferReward> OfferRewards { get; set; } = null!;
        public virtual DbSet<Offerlist> Offerlists { get; set; } = null!;
        public virtual DbSet<PairColeftRightYard> PairColeftRightYards { get; set; } = null!;
        public virtual DbSet<ParingCalculation> ParingCalculations { get; set; } = null!;
        public virtual DbSet<PaymentRecieve> PaymentRecieves { get; set; } = null!;
        public virtual DbSet<PlotDetail> PlotDetails { get; set; } = null!;
        public virtual DbSet<PromoIncomeDetail> PromoIncomeDetails { get; set; } = null!;
        public virtual DbSet<PromotionalBanner> PromotionalBanners { get; set; } = null!;
        public virtual DbSet<PromotionalIncomeCalculation> PromotionalIncomeCalculations { get; set; } = null!;
        public virtual DbSet<ShecdularEntry> ShecdularEntries { get; set; } = null!;
        public virtual DbSet<SiteMaster> SiteMasters { get; set; } = null!;
        public virtual DbSet<SiteRate> SiteRates { get; set; } = null!;
        public virtual DbSet<Slip> Slips { get; set; } = null!;
        public virtual DbSet<SlipNew> SlipNews { get; set; } = null!;
        public virtual DbSet<Testimonial> Testimonials { get; set; } = null!;
        public virtual DbSet<UserAwardLevel> UserAwardLevels { get; set; } = null!;
        public virtual DbSet<UserAwardOneThirdPay> UserAwardOneThirdPays { get; set; } = null!;
        public virtual DbSet<UserLevel> UserLevels { get; set; } = null!;
        public virtual DbSet<UserLogin> UserLogins { get; set; } = null!;
        public virtual DbSet<UserLoginNew> UserLoginNews { get; set; } = null!;
        public virtual DbSet<UserNewLabelPlan> UserNewLabelPlans { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=103.154.184.118;database=osr_new;User ID=osr_new;Password=kapil#$%^12345@#$;Trusted_Connection=False;TrustServerCertificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("osr_new");

            modelBuilder.Entity<AwardCalculation>(entity =>
            {
                entity.ToTable("AwardCalculation", "dbo");

                entity.Property(e => e.CalculatedId).HasColumnName("Calculated_Id");

                entity.Property(e => e.GenerateDate).HasColumnType("datetime");

                entity.Property(e => e.UserDetailId).HasColumnName("UserDetail_Id");
            });

            modelBuilder.Entity<AwardMaster>(entity =>
            {
                entity.ToTable("AwardMaster", "dbo");
            });

            modelBuilder.Entity<BannerImage>(entity =>
            {
                entity.ToTable("BannerImage");

                entity.Property(e => e.BannerImage1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BannerImage");
            });

            modelBuilder.Entity<BookPlotForAdmin>(entity =>
            {
                entity.ToTable("BookPlotForAdmin");

                entity.Property(e => e.Amount).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Mobile).HasMaxLength(11);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Broker>(entity =>
            {
                entity.ToTable("Broker", "dbo");

                entity.Property(e => e.AdhaarNo).HasMaxLength(20);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile).HasMaxLength(15);

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PanNo).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Role)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasMaxLength(50);
            });

            modelBuilder.Entity<BrokerSite>(entity =>
            {
                entity.ToTable("BrokerSite");

                entity.Property(e => e.Area)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BookingAmount).HasMaxLength(50);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Mobile).HasMaxLength(11);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Emi>(entity =>
            {
                entity.ToTable("Emi", "dbo");

                entity.Property(e => e.ActiveDate).HasColumnType("datetime");

                entity.Property(e => e.BankName).HasMaxLength(100);

                entity.Property(e => e.ChequeNo).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EmiDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Mop)
                    .HasMaxLength(100)
                    .HasColumnName("MOP");

                entity.Property(e => e.NextEmiDate).HasColumnType("datetime");

                entity.Property(e => e.SlipId).HasColumnName("Slip_Id");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.DateOfBirth).HasColumnType("date");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(10);
            });

            modelBuilder.Entity<Gallery>(entity =>
            {
                entity.ToTable("Gallery", "dbo");
            });

            modelBuilder.Entity<IncomeAndReward>(entity =>
            {
                entity.ToTable("IncomeAndReward", "dbo");
            });

            modelBuilder.Entity<IncomeWallet>(entity =>
            {
                entity.ToTable("IncomeWallet", "dbo");

                entity.Property(e => e.IncomeType).HasMaxLength(30);

                entity.Property(e => e.TransactionType).HasMaxLength(2);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.ToTable("Level");

                entity.Property(e => e.Commission).HasMaxLength(50);

                entity.Property(e => e.Post)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NewPlan>(entity =>
            {
                entity.ToTable("NewPlan");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.ActiveDate).HasColumnType("datetime");

                entity.Property(e => e.AdminLoginId).HasColumnName("AdminLogin_Id");

                entity.Property(e => e.Advance).HasMaxLength(50);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNumber).HasMaxLength(50);

                entity.Property(e => e.Commision).HasMaxLength(50);

                entity.Property(e => e.CreateDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Dob)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber).HasMaxLength(11);

                entity.Property(e => e.ModeOfPayment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Mother_Name");

                entity.Property(e => e.NomineeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OfficeNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PanNumber).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("Parent_Id");

                entity.Property(e => e.PerMonthAmount).HasMaxLength(50);

                entity.Property(e => e.PermanentAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PlotDetailId).HasColumnName("PlotDetail_Id");

                entity.Property(e => e.PresentAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rate).HasMaxLength(50);

                entity.Property(e => e.RegistryDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SiteMasterId).HasColumnName("SiteMaster_Id");

                entity.Property(e => e.SponsorId).HasMaxLength(50);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Total).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.Yards).HasMaxLength(50);
            });

            modelBuilder.Entity<OfferPyout>(entity =>
            {
                entity.ToTable("offerPyout", "dbo");

                entity.Property(e => e.Income).HasColumnName("income");

                entity.Property(e => e.IncomeId).HasMaxLength(30);

                entity.Property(e => e.TodayDate)
                    .HasMaxLength(30)
                    .HasColumnName("todayDate");

                entity.Property(e => e.Uid)
                    .HasMaxLength(30)
                    .HasColumnName("UId");

                entity.Property(e => e.Uname)
                    .HasMaxLength(100)
                    .HasColumnName("UName");
            });

            modelBuilder.Entity<OfferReward>(entity =>
            {
                entity.ToTable("OfferReward", "dbo");

                entity.Property(e => e.Reward).HasMaxLength(50);

                entity.Property(e => e.TodayDate).HasMaxLength(30);

                entity.Property(e => e.Uid)
                    .HasMaxLength(50)
                    .HasColumnName("UId");
            });

            modelBuilder.Entity<Offerlist>(entity =>
            {
                entity.ToTable("Offerlist", "dbo");
            });

            modelBuilder.Entity<PairColeftRightYard>(entity =>
            {
                entity.ToTable("PairCOLeftRightYards", "dbo");
            });

            modelBuilder.Entity<ParingCalculation>(entity =>
            {
                entity.ToTable("ParingCalculation", "dbo");

                entity.Property(e => e.GenerateDate).HasColumnType("datetime");

                entity.Property(e => e.PairedId).HasColumnName("Paired_Id");

                entity.Property(e => e.UserDetailId).HasColumnName("UserDetail_Id");
            });

            modelBuilder.Entity<PaymentRecieve>(entity =>
            {
                entity.ToTable("PaymentRecieve");

                entity.Property(e => e.Amount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate).HasColumnType("date");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlotDetail>(entity =>
            {
                entity.ToTable("PlotDetail", "dbo");

                entity.Property(e => e.PlotIdPrefix).IsUnicode(false);

                entity.Property(e => e.PlotNumber).HasMaxLength(100);

                entity.Property(e => e.PlotNumber2).IsUnicode(false);

                entity.Property(e => e.PlotNumberShop2).IsUnicode(false);

                entity.Property(e => e.PlotType1).IsUnicode(false);

                entity.Property(e => e.ShopSize2).IsUnicode(false);

                entity.Property(e => e.SiteMasterId).HasColumnName("SiteMaster_Id");

                entity.Property(e => e.Size2).IsUnicode(false);

                entity.Property(e => e.Status).IsUnicode(false);

                entity.Property(e => e.TotalArea).HasMaxLength(50);
            });

            modelBuilder.Entity<PromoIncomeDetail>(entity =>
            {
                entity.ToTable("PromoIncomeDetail", "dbo");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.UserDetailId).HasColumnName("UserDetail_Id");
            });

            modelBuilder.Entity<PromotionalBanner>(entity =>
            {
                entity.ToTable("PromotionalBanner");

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PromotionalIncomeCalculation>(entity =>
            {
                entity.ToTable("PromotionalIncomeCalculation", "dbo");

                entity.Property(e => e.GenerateDate).HasColumnType("datetime");

                entity.Property(e => e.IncomeCalculatedId).HasColumnName("IncomeCalculated_Id");

                entity.Property(e => e.UserDetailId).HasColumnName("UserDetail_Id");
            });

            modelBuilder.Entity<ShecdularEntry>(entity =>
            {
                entity.ToTable("ShecdularEntry", "dbo");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SiteMaster>(entity =>
            {
                entity.ToTable("SiteMaster", "dbo");

                entity.Property(e => e.SiteAddress).HasMaxLength(200);

                entity.Property(e => e.SiteDescription).HasMaxLength(100);

                entity.Property(e => e.SiteName).HasMaxLength(100);
            });

            modelBuilder.Entity<SiteRate>(entity =>
            {
                entity.ToTable("SiteRate", "dbo");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.SiteMasterId).HasColumnName("SiteMaster_Id");
            });

            modelBuilder.Entity<Slip>(entity =>
            {
                entity.ToTable("Slip", "dbo");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.ActiveDate).HasColumnType("datetime");

                entity.Property(e => e.AdminLoginId).HasColumnName("AdminLogin_Id");

                entity.Property(e => e.BankName).HasMaxLength(100);

                entity.Property(e => e.ChequeNumber).HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Dob).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.IsLeft).HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileNumber).HasMaxLength(100);

                entity.Property(e => e.ModeOfPayment).HasMaxLength(100);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(300)
                    .HasColumnName("Mother_Name");

                entity.Property(e => e.NomineeName).HasMaxLength(200);

                entity.Property(e => e.OfficeNumber).HasMaxLength(12);

                entity.Property(e => e.PanFatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pan_FatherName");

                entity.Property(e => e.PanNumber).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("Parent_Id");

                entity.Property(e => e.PlotDetailId).HasColumnName("PlotDetail_Id");

                entity.Property(e => e.RegistryDate).HasColumnType("datetime");

                entity.Property(e => e.SpillSponsorId).HasColumnName("SpillSponsor_Id");

                entity.Property(e => e.Status).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SlipNew>(entity =>
            {
                entity.ToTable("SlipNew", "dbo");

                entity.Property(e => e.AccountNumber).HasMaxLength(50);

                entity.Property(e => e.ActiveDate).HasColumnType("datetime");

                entity.Property(e => e.AdminLoginId).HasColumnName("AdminLogin_Id");

                entity.Property(e => e.BankName).HasMaxLength(100);

                entity.Property(e => e.ChequeNumber).HasMaxLength(100);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Dob).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.FatherName).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.IsLeft).HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileNumber).HasMaxLength(100);

                entity.Property(e => e.ModeOfPayment).HasMaxLength(100);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(300)
                    .HasColumnName("Mother_Name");

                entity.Property(e => e.NomineeName).HasMaxLength(200);

                entity.Property(e => e.OfficeNumber).HasMaxLength(12);

                entity.Property(e => e.PanFatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Pan_FatherName");

                entity.Property(e => e.PanNumber).HasMaxLength(50);

                entity.Property(e => e.ParentId).HasColumnName("Parent_Id");

                entity.Property(e => e.PlotDetailId).HasColumnName("PlotDetail_Id");

                entity.Property(e => e.Post)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RegistryDate).HasColumnType("datetime");

                entity.Property(e => e.SpillSponsorId).HasColumnName("SpillSponsor_Id");

                entity.Property(e => e.Status).HasMaxLength(150);

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Testimonial>(entity =>
            {
                entity.ToTable("Testimonial");

                entity.Property(e => e.Discription).IsUnicode(false);

                entity.Property(e => e.ImageName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UserAwardLevel>(entity =>
            {
                entity.ToTable("UserAwardLevel", "dbo");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.ULevel).HasColumnName("uLevel");
            });

            modelBuilder.Entity<UserAwardOneThirdPay>(entity =>
            {
                entity.ToTable("UserAwardOneThirdPay", "dbo");

                entity.Property(e => e.SlipId).HasColumnName("Slip_Id");

                entity.Property(e => e.SponsorId).HasMaxLength(50);

                entity.Property(e => e.TodayDate).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<UserLevel>(entity =>
            {
                entity.ToTable("UserLevel", "dbo");

                entity.Property(e => e.CompletionDate).HasColumnType("datetime");

                entity.Property(e => e.LabelName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("labelName");

                entity.Property(e => e.ULevel).HasColumnName("uLevel");
            });

            modelBuilder.Entity<UserLogin>(entity =>
            {
                entity.ToTable("UserLogin", "dbo");

                entity.Property(e => e.ImageName).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Password2).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<UserLoginNew>(entity =>
            {
                entity.ToTable("UserLoginNew", "dbo");

                entity.Property(e => e.ImageName).HasMaxLength(200);

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Password2).HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<UserNewLabelPlan>(entity =>
            {
                entity.ToTable("UserNewLabelPlan");

                entity.Property(e => e.UserLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
