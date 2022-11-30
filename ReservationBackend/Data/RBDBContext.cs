using System;
using MediaComposer.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ReservationBackend.Data.Entities;

namespace ReservationBackend.Data
{
    public partial class RBDBContext : DbContext
    {
        public RBDBContext()
        {
        }

        public RBDBContext(DbContextOptions<RBDBContext> options)
            : base(options)
        {
        }

       
        public virtual DbSet<Client> Client { get; set; }

        public virtual DbSet<Provider> Provider { get; set; }

        public virtual DbSet<Schedule> Schedule { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Client>(entity =>
            {
               
            });

            modelBuilder.Entity<Provider>(entity =>
            {

            });

            modelBuilder.Entity<Schedule>(entity =>
            {
              
            });

          
        }
    }
}
