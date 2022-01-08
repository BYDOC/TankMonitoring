using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TankMonitoring.Data.Models.ORM.Entity;

#nullable disable

namespace TankMonitoring.Data.Models.ORM.context
{
    public partial class EPDK_TANKContext : DbContext
    {
        public EPDK_TANKContext()
        {
        }

        public EPDK_TANKContext(DbContextOptions<EPDK_TANKContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<EpdkDep1> EpdkDep1s { get; set; }
        public virtual DbSet<EpdkDep2> EpdkDep2s { get; set; }
        public virtual DbSet<EpdkDr> EpdkDrs { get; set; }
        public virtual DbSet<Epdkoption> Epdkoptions { get; set; }
        public virtual DbSet<Epdkproduct> Epdkproducts { get; set; }
        public virtual DbSet<Epdktank> Epdktanks { get; set; }
        public virtual DbSet<Epdkuser> Epdkusers { get; set; }
        public virtual DbSet<Kullanicilar> Kullanicilars { get; set; }
        public virtual DbSet<LtcustomsStatus> LtcustomsStatuses { get; set; }
        public virtual DbSet<Menuler> Menulers { get; set; }
        public virtual DbSet<Opcexport> Opcexports { get; set; }
        public virtual DbSet<RentedDepot> RentedDepots { get; set; }
        public virtual DbSet<ReportSetting> ReportSettings { get; set; }
        public virtual DbSet<TankGroup> TankGroups { get; set; }
        public virtual DbSet<TankLastStatus> TankLastStatuses { get; set; }
        public virtual DbSet<TankModbusTable> TankModbusTables { get; set; }
        public virtual DbSet<TankTransaction> TankTransactions { get; set; }
        public virtual DbSet<Terminal> Terminals { get; set; }
        public virtual DbSet<VEpdkDep1> VEpdkDep1s { get; set; }
        public virtual DbSet<VEpdkDep2> VEpdkDep2s { get; set; }
        public virtual DbSet<VEpdkDr> VEpdkDrs { get; set; }
        public virtual DbSet<VEpdktank> VEpdktanks { get; set; }
        public virtual DbSet<VTankLastStatus> VTankLastStatuses { get; set; }
        public virtual DbSet<VTankTransaction> VTankTransactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=EPDK_TANK;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EpdkDep1>(entity =>
            {
                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dep1status)
                    .HasDefaultValueSql("((1))")
                    .HasComment("0=Yeni,1=Gönderilmeye Hazır,2=Gönderiliyor,3=Gönderildi,4=Gönderilemedi");
            });

            modelBuilder.Entity<EpdkDep2>(entity =>
            {
                entity.Property(e => e.Dep2status)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0=Yeni,1=Gönderilmeye Hazır,2=Gönderiliyor,3=Gönderildi,4=Gönderilemedi");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<EpdkDr>(entity =>
            {
                entity.Property(e => e.DrTransferred)
                    .HasDefaultValueSql("((0))")
                    .HasComment("0=Yeni,1=Gönderilmeye Hazır,2=Gönderiliyor,3=Gönderildi,4=Gönderilemedi");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Epdkoption>(entity =>
            {
                entity.Property(e => e.DtaoptionsId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Epdkproduct>(entity =>
            {
                entity.Property(e => e.Epdkuser).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Epdktank>(entity =>
            {
                entity.Property(e => e.AmbientTemp)
                    .HasDefaultValueSql("((15))")
                    .HasComment("0 ise gümrüksüz, 1 ise gümrüklü");

                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CustomsStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVisible).HasDefaultValueSql("((1))");

                entity.Property(e => e.IsVisibleForAdmin).HasDefaultValueSql("((1))");

                entity.Property(e => e.Maintenance).HasDefaultValueSql("((0))");

                entity.Property(e => e.TankGroupId).HasDefaultValueSql("((1))");

                entity.Property(e => e.TerminalId).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Epdkuser>(entity =>
            {
                entity.Property(e => e.SaabUserId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Kullanicilar>(entity =>
            {
                entity.Property(e => e.Adi).IsUnicode(false);

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.KullaniciAdi).IsUnicode(false);

                entity.Property(e => e.KullaniciFotograf).IsUnicode(false);

                entity.Property(e => e.KullaniciParola).IsUnicode(false);

                entity.Property(e => e.Soyadi).IsUnicode(false);

                entity.Property(e => e.Telefon).IsUnicode(false);
            });

            modelBuilder.Entity<LtcustomsStatus>(entity =>
            {
                entity.Property(e => e.CustomsStatusId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Menuler>(entity =>
            {
                entity.Property(e => e.Class).IsUnicode(false);

                entity.Property(e => e.Link).IsUnicode(false);

                entity.Property(e => e.MenuBaslik).IsUnicode(false);
            });

            modelBuilder.Entity<Opcexport>(entity =>
            {
                entity.Property(e => e.OpcAvgTemp).IsUnicode(false);

                entity.Property(e => e.OpcCalcWia).IsUnicode(false);

                entity.Property(e => e.OpcDensity).IsUnicode(false);

                entity.Property(e => e.OpcGov).IsUnicode(false);

                entity.Property(e => e.OpcNsv).IsUnicode(false);

                entity.Property(e => e.OpcNsvdiff).IsUnicode(false);

                entity.Property(e => e.OpcTankLevel).IsUnicode(false);

                entity.Property(e => e.OpcTankRefName).IsUnicode(false);

                entity.Property(e => e.OpcTankRefProduct).IsUnicode(false);

                entity.Property(e => e.OpcTov).IsUnicode(false);

                entity.Property(e => e.OpcVaporPressure).IsUnicode(false);

                entity.Property(e => e.OpcWia).IsUnicode(false);

                entity.Property(e => e.OpcexportId).ValueGeneratedOnAdd();

                entity.Property(e => e.TankRefName).IsUnicode(false);

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<RentedDepot>(entity =>
            {
                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ReportSetting>(entity =>
            {
                entity.Property(e => e.ReportId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TankGroup>(entity =>
            {
                entity.Property(e => e.TankGroupId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TankLastStatus>(entity =>
            {
                entity.Property(e => e.TankStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.VaporPressure).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TankModbusTable>(entity =>
            {
                entity.Property(e => e.AvgTempAdr).HasDefaultValueSql("((0))");

                entity.Property(e => e.DensityAdr).HasDefaultValueSql("((0))");

                entity.Property(e => e.ErrorAdr).HasDefaultValueSql("((0))");

                entity.Property(e => e.Govadr).HasDefaultValueSql("((0))");

                entity.Property(e => e.LevelAdr).HasDefaultValueSql("((0))");

                entity.Property(e => e.MassAdr).HasDefaultValueSql("((0))");

                entity.Property(e => e.Nsvadr).HasDefaultValueSql("((0))");

                entity.Property(e => e.StatusAdr).HasDefaultValueSql("((0))");

                entity.Property(e => e.Tovadr).HasDefaultValueSql("((0))");

                entity.Property(e => e.UpdateDate).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<TankTransaction>(entity =>
            {
                entity.Property(e => e.TankTransactionId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Terminal>(entity =>
            {
                entity.Property(e => e.CreateDate).HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TerminalId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<VEpdkDep1>(entity =>
            {
                entity.ToView("vEPDK_Dep1");
            });

            modelBuilder.Entity<VEpdkDep2>(entity =>
            {
                entity.ToView("vEPDK_Dep2");
            });

            modelBuilder.Entity<VEpdkDr>(entity =>
            {
                entity.ToView("vEPDK_DR");
            });

            modelBuilder.Entity<VEpdktank>(entity =>
            {
                entity.ToView("vEPDKTanks");
            });

            modelBuilder.Entity<VTankLastStatus>(entity =>
            {
                entity.ToView("vTankLastStatus");
            });

            modelBuilder.Entity<VTankTransaction>(entity =>
            {
                entity.ToView("vTankTransactions");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
