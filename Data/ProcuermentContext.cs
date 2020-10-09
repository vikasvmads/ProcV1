using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Procuerment.Models
{
    public partial class ProcuermentContext : DbContext
    {
        public ProcuermentContext()
        {
        }

        public ProcuermentContext(DbContextOptions<ProcuermentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaselineType> BaselineType { get; set; }
        public virtual DbSet<CompanyCode> CompanyCode { get; set; }
        public virtual DbSet<FinancialStatementArea> FinancialStatementArea { get; set; }
        public virtual DbSet<InitiativeStatus> InitiativeStatus { get; set; }
        public virtual DbSet<MaterialGroup> MaterialGroup { get; set; }
        public virtual DbSet<MaterialGroupDesccription> MaterialGroupDesccription { get; set; }
        public virtual DbSet<MaterialMater> MaterialMater { get; set; }
        public virtual DbSet<MilestoneStatus> MilestoneStatus { get; set; }
        public virtual DbSet<Period> Period { get; set; }
        public virtual DbSet<PlantName> PlantName { get; set; }
        public virtual DbSet<Procurement> Procurement { get; set; }
        public virtual DbSet<Models.PurchaseOrganization> PurchaseOrganization { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Supplier> Supplier { get; set; }
        public virtual DbSet<ValueContribution> ValueContribution { get; set; }
        public virtual DbSet<ValueLever> ValueLever { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.UserRoleMapping>()
               .HasOne<Models.Role>()
               .WithMany()
               .HasForeignKey(p => p.RoleId);

            modelBuilder.Entity<Models.UserRoleMapping>()
               .HasOne<Models.UserInfo>()
               .WithMany()
               .HasForeignKey(p => p.UserId);
            modelBuilder.Entity<BaselineType>(entity =>
            {
                entity.HasKey(e => e.BaselineId);

                entity.Property(e => e.BaselineId).HasColumnName("BaselineID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CompanyCode>(entity =>
            {
                entity.HasKey(e => e.PocompanyCode)
                    .HasName("CompanyCode_pk");

                entity.Property(e => e.PocompanyCode)
                    .HasColumnName("POCompanyCode")
                    .ValueGeneratedNever();

                entity.Property(e => e.PocompanyName)
                    .IsRequired()
                    .HasColumnName("POCompanyName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FinancialStatementArea>(entity =>
            {
                entity.Property(e => e.FinancialStatementAreaId).HasColumnName("FinancialStatementAreaID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InitiativeStatus>(entity =>
            {
                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialGroup>(entity =>
            {
                entity.HasKey(e => e.UnspscMaterial)
                    .HasName("MaterialGroup_pk");

                entity.Property(e => e.UnspscMaterial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialGroupDesccription>(entity =>
            {
                entity.HasKey(e => e.MaterialType)
                    .HasName("MaterialGroupDesccription_pk");

                entity.Property(e => e.MaterialType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialTypeDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MaterialMater>(entity =>
            {
                entity.HasKey(e => e.MaterialId)
                    .HasName("MaterialMater_pk");

                entity.Property(e => e.MaterialId).ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialType)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MilestoneStatus>(entity =>
            {
                entity.Property(e => e.MilestoneStatusId).HasColumnName("MilestoneStatusID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Period>(entity =>
            {
                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PlantName>(entity =>
            {
                entity.HasKey(e => e.PlantId)
                    .HasName("PlantName_pk");

                entity.Property(e => e.PlantId).ValueGeneratedNever();

                entity.Property(e => e.PlantName1)
                    .IsRequired()
                    .HasColumnName("PlantName")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Procurement>(entity =>
            {
                entity.ToTable("procurement");

                entity.Property(e => e.ProcurementId).HasColumnName("ProcurementID");

                entity.Property(e => e.BaselineId).HasColumnName("BaselineID");

                entity.Property(e => e.BaselinedetailsPrice).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.BaselinedetailsPriceunit).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.BaselinedetailsQty).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.BaselinedetailsUom)
                    .IsRequired()
                    .HasColumnName("BaselinedetailsUOM")
                    .HasMaxLength(5)
                    .IsUnicode(false);



                entity.Property(e => e.CostReduction).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Creationdate).HasColumnType("datetime");

                entity.Property(e => e.Currency)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyImpact)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CurrencyType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Discountgiven)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Division)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EstimatedSavings).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.ExternalCost).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.FinancialStatementAreaId).HasColumnName("FinancialStatementAreaID");

                entity.Property(e => e.IndexsavingConsideration)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InitiativeDescription)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InitiativeTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Initiativedetails)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.InitiativedetailsDiscountgiven).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.InitiativedetailsNewSpendvalue).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.InitiativedetailsNewprice).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.InitiativedetailsPriceIncrease).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.InternalCost).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.LeverDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Material)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaterialSubstitution)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Methods)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MilestoneActualDuedate).HasColumnType("datetime");

                entity.Property(e => e.MilestoneDescription)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MilestonePlannedDuedate).HasColumnType("datetime");

                entity.Property(e => e.MilestoneStartdatemilestone).HasColumnType("datetime");

                entity.Property(e => e.MilestoneStatusId).HasColumnName("MilestoneStatusID");

                entity.Property(e => e.NetSavings).HasColumnType("decimal(20, 4)");

                entity.Property(e => e.NewMaterial)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PeriodId).HasColumnName("PeriodID");

                entity.Property(e => e.PriceIncrease)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PurchaseOrganization)
                    .IsRequired()
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Qty)
                    .HasColumnName("QTY")
                    .HasColumnType("decimal(20, 4)");

                entity.Property(e => e.Remarks)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Uom)
                    .IsRequired()
                    .HasColumnName("UOM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ValueContributionId).HasColumnName("ValueContributionID");

                entity.Property(e => e.ValueLeverId).HasColumnName("ValueLeverID");

                entity.Property(e => e.VolumeIncrease)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Baseline)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.BaselineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__procureme__Basel__4E88ABD4");

                entity.HasOne(d => d.CompanyCodeNavigation)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.CompanyCode)
                    .HasConstraintName("FK__procureme__Compa__09A971A2");

                entity.HasOne(d => d.FinancialStatementArea)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.FinancialStatementAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__procureme__Finan__52593CB8");

                entity.HasOne(d => d.InitiativeStatus)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.InitiativeStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__procureme__Initi__5070F446");

                entity.HasOne(d => d.MaterialDescriptionNavigation)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.MaterialDescription)
                    .HasConstraintName("FK__procureme__Mater__07C12930");

                entity.HasOne(d => d.MaterialGroupNavigation)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.MaterialGroup)
                    .HasConstraintName("FK__procureme__Mater__7C4F7684");

                entity.HasOne(d => d.MilestoneStatus)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.MilestoneStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__procureme__Miles__5535A963");

                entity.HasOne(d => d.Period)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.PeriodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__procureme__Perio__5441852A");

                entity.HasOne(d => d.Plant)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.PlantId)
                    .HasConstraintName("FK__procureme__Plant__0F624AF8");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__procureme__RoleI__534D60F1");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK__procureme__Suppl__0E6E26BF");

                entity.HasOne(d => d.ValueContribution)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.ValueContributionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__procureme__Value__5165187F");

                entity.HasOne(d => d.ValueLever)
                    .WithMany(p => p.Procurement)
                    .HasForeignKey(d => d.ValueLeverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__procureme__Value__4F7CD00D");
            });

            modelBuilder.Entity<PurchaseOrganization>(entity =>
            {
                entity.HasKey(e => e.PurchaseOrganization1)
                    .HasName("PurchaseOrganization_pk");

                entity.Property(e => e.PurchaseOrganization1)
                    .HasColumnName("PurchaseOrganization")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationDescription)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.RoleId);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.VendorId)
                    .HasName("Supplier_pk");

                entity.Property(e => e.VendorId).ValueGeneratedNever();

                entity.Property(e => e.VendorCountry)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VendorType)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ValueContribution>(entity =>
            {
                entity.Property(e => e.ValueContributionId).HasColumnName("ValueContributionID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ValueLever>(entity =>
            {
                entity.Property(e => e.ValueLeverId).HasColumnName("ValueLeverID");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
