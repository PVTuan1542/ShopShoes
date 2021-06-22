using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace test.EFS
{
    public partial class DBContextWeb : DbContext
    {
        public DBContextWeb()
            : base("name=DBContextWeb")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<product> products { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.user)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.pass)
                .IsUnicode(false);

            modelBuilder.Entity<product>()
                .Property(e => e.price)
                .HasPrecision(19, 4);
        }
    }
}
