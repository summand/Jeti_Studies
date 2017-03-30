namespace Jeti_v0
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CF1 : DbContext
    {
        public CF1()
            : base("JETI")
        {
        }

        public virtual DbSet<ActiveContract> ActiveContracts { get; set; }
        public virtual DbSet<PriceCapture> PriceCaptures { get; set; }
        public virtual DbSet<SecurityMaster> SecurityMasters { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActiveContract>()
                .Property(e => e.IBFuturesLocalSymbol)
                .IsUnicode(false);

            modelBuilder.Entity<PriceCapture>()
                .Property(e => e.Ticker)
                .IsUnicode(false);

            modelBuilder.Entity<SecurityMaster>()
                .Property(e => e.SecType)
                .IsUnicode(false);

            modelBuilder.Entity<SecurityMaster>()
                .Property(e => e.Exchange)
                .IsUnicode(false);

            modelBuilder.Entity<SecurityMaster>()
                .Property(e => e.Currency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<SecurityMaster>()
                .Property(e => e.IBFuturesLocalSymbol)
                .IsUnicode(false);

            modelBuilder.Entity<SecurityMaster>()
                .Property(e => e.FuturesGenericSymbol)
                .IsUnicode(false);

            modelBuilder.Entity<SecurityMaster>()
                .Property(e => e.FuturesYearCode)
                .IsUnicode(false);

            modelBuilder.Entity<SecurityMaster>()
                .Property(e => e.FuturesMonth)
                .IsUnicode(false);

            modelBuilder.Entity<SecurityMaster>()
                .Property(e => e.FuturesMonthCode)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
