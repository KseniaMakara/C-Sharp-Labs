using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;


namespace Lab5p.Models
{
    public partial class DCLab5pLAB5PMDFContext : DbContext
    {
        public DCLab5pLAB5PMDFContext()
        {
        }

        public DCLab5pLAB5PMDFContext(DbContextOptions<DCLab5pLAB5PMDFContext> options)
            : base(options)
        {
        }

        public virtual DBSet<Manga> Manga { get; set; }
        public virtual DBSet<Pages> Pages { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=Lab5p");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Manga>(entity =>
            {
                entity.Property(e => e.Published).HasColumnType("date");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Pages>(entity =>
            {
                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Jojo)
                    .WithMany(p => p.Pages)
                    .HasForeignKey(d => d.MangaId)
                    .HasConstraintName("FK_Pages_Manga");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
