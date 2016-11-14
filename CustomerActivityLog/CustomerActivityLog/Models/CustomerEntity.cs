namespace CustomerActivityLog
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CustomerEntity : DbContext { 

        public virtual DbSet<BlockActivityLog> BlockActivityLogs { get; set; }
        public virtual DbSet<FieldActivityLog> FieldActivityLogs { get; set; }
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
