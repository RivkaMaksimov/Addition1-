using System;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Repositories.Models
{
    public partial class HMO_corona_database : DbContext
    {
        public HMO_corona_database()
        {
        }
     
        public HMO_corona_database(DbContextOptions<HMO_corona_database> options)
            : base(options)
        {
        }

        public virtual DbSet<TblCoronaDisease> TblCoronaDisease { get; set; }
        public virtual DbSet<TblCustomers> TblCustomers { get; set; }
        public virtual DbSet<TblVaccineGetting> TblVaccineGetting { get; set; }
        public virtual DbSet<TblVaccines> TblVaccines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=den1.mssql7.gear.host;Initial Catalog=hmocoronadb;User ID=hmocoronadb;Password=Dt9t_F-AtpkV");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCoronaDisease>(entity =>
            {
                entity.HasKey(e => e.DiseaseId)
                    .HasName("PK__tblCoron__15627065D12BE9AA");

                entity.ToTable("tblCorona_disease");

                entity.Property(e => e.DiseaseId).HasColumnName("disease_id");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(15);

                entity.Property(e => e.PositiveResult)
                    .HasColumnName("positive_result")
                    .HasColumnType("date");

                entity.Property(e => e.RecoveryDate)
                    .HasColumnName("recovery_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblCoronaDisease)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK__tblCorona__custo__3E52440B");
            });

            modelBuilder.Entity<TblCustomers>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PK__tblCusto__CD65CB852D0F0830");

                entity.ToTable("tblCustomers");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(15);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("date");

                entity.Property(e => e.CustomerAddress)
                    .HasColumnName("customer_address")
                    .HasMaxLength(100);

                entity.Property(e => e.CustomerFirstName)
                    .IsRequired()
                    .HasColumnName("customer_first_name")
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerLastName)
                    .IsRequired()
                    .HasColumnName("customer_last_name")
                    .HasMaxLength(30);

                entity.Property(e => e.MobilePhone)
                    .HasColumnName("mobile_phone")
                    .HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .HasColumnName("phone")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TblVaccineGetting>(entity =>
            {
                entity.HasKey(e => new { e.VaccineId, e.CustomerId })
                    .HasName("PK__tblVacci__F945B30B59CCD181");

                entity.ToTable("tblVaccine_getting");

                entity.Property(e => e.VaccineId).HasColumnName("vaccine_id");

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customer_id")
                    .HasMaxLength(15);

                entity.Property(e => e.GettingDate)
                    .HasColumnName("getting_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.TblVaccineGetting)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblVaccin__custo__44FF419A");

                entity.HasOne(d => d.Vaccine)
                    .WithMany(p => p.TblVaccineGetting)
                    .HasForeignKey(d => d.VaccineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__tblVaccin__vacci__440B1D61");
            });

            modelBuilder.Entity<TblVaccines>(entity =>
            {
                entity.HasKey(e => e.VaccineId)
                    .HasName("PK__tblVacci__B593EFB365831D10");

                entity.ToTable("tblVaccines");

                entity.Property(e => e.VaccineId).HasColumnName("vaccine_id");

                entity.Property(e => e.ManufacturerName)
                    .HasColumnName("manufacturer_name")
                    .HasMaxLength(50);

                entity.Property(e => e.VaccineName)
                    .HasColumnName("vaccine_name")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
