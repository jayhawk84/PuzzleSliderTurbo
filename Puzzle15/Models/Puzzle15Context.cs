using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Puzzle15.Models
{
    public partial class Puzzle15Context : DbContext
    {
        public Puzzle15Context()
        {
        }

        public Puzzle15Context(DbContextOptions<Puzzle15Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Pictures> Pictures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=JASONPC;Database=Puzzle15;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pictures>(entity =>
            {
                entity.HasKey(e => e.PicId)
                    .HasName("PK__pictures__06707FCDD130065D");

                entity.ToTable("pictures");

                entity.Property(e => e.PicId).HasColumnName("picID");

                entity.Property(e => e.PicName)
                    .HasColumnName("picName")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
