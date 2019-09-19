using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace taskApi.Models
{
    public partial class SUPERO_INTELBRASContext : DbContext
    {
        public SUPERO_INTELBRASContext()
        {
        }

        public SUPERO_INTELBRASContext(DbContextOptions<SUPERO_INTELBRASContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Task> Task { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Task>(entity =>
            {
                entity.Property(e => e.Descript)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
