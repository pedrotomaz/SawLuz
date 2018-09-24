namespace SawLuz.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Contexto : DbContext
    {
        public Contexto()
            : base("name=Contexto")
        {
        }

        //public virtual DbSet<database_firewall_rules> database_firewall_rules { get; set; }
        public DbSet<Restaurante> Restaurantes { get; set; }
        public DbSet<Prato> Pratos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<database_firewall_rules>()
            //    .Property(e => e.start_ip_address)
            //    .IsUnicode(false);

            //modelBuilder.Entity<database_firewall_rules>()
            //    .Property(e => e.end_ip_address)
            //    .IsUnicode(false);
        }
    }
}
