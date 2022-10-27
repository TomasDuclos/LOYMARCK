using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace LOYMARK.Models
{
    public partial class LoymarkContext : DbContext
    {
        public LoymarkContext()
        {
        }

        public LoymarkContext(DbContextOptions<LoymarkContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Activity> Activity { get; set; } = null!;
        public virtual DbSet<User> User { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Loymark;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("Activity");

                entity.Property(e => e.CreateDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(entity.Property<int>("UserId"), 1L, 1);

                entity.Property(e => e.Country)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DateBirth).HasColumnType("date");

                entity.Property(e => e.FirtsName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mail)
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
