using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CooperTestDemo.Entities
{
    public partial class cooperTestContext : DbContext
    {
        public cooperTestContext()
        {
        }

        public cooperTestContext(DbContextOptions<cooperTestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Athlete> Athlete { get; set; }
        public virtual DbSet<AthleteTests> AthleteTests { get; set; }
        public virtual DbSet<Tests> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=W81-DPANCHAL;Initial Catalog=cooperTest;User ID=sa;Password=rays@123;Database=cooperTest;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Athlete>(entity =>
            {
                entity.ToTable("athlete");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("last_updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasColumnName("record_status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AthleteTests>(entity =>
            {
                entity.ToTable("athlete_tests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AthleteId).HasColumnName("athlete_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Distance)
                    .HasColumnName("distance")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("last_updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecordStatus)
                    .HasColumnName("record_status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestId).HasColumnName("test_id");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Athlete)
                    .WithMany(p => p.AthleteTests)
                    .HasForeignKey(d => d.AthleteId)
                    .HasConstraintName("FK_athlete_tests_athlete");

                entity.HasOne(d => d.Test)
                    .WithMany(p => p.AthleteTests)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK_athlete_tests_tests");
            });

            modelBuilder.Entity<Tests>(entity =>
            {
                entity.ToTable("tests");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastUpdated)
                    .HasColumnName("last_updated")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecordStatus)
                    .HasColumnName("record_status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TestDate)
                    .HasColumnName("test_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updated_by")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
