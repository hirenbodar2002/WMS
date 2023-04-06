using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WMSinWeb.Entities.DataModels
{
    public partial class WarehouseManagementContext : DbContext
    {
        public WarehouseManagementContext()
        {
        }

        public WarehouseManagementContext(DbContextOptions<WarehouseManagementContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CustomerTbl> CustomerTbls { get; set; } = null!;
        public virtual DbSet<LoginTbl> LoginTbls { get; set; } = null!;
        public virtual DbSet<ProductTbl> ProductTbls { get; set; } = null!;
        public virtual DbSet<SupplierTbl> SupplierTbls { get; set; } = null!;
        public virtual DbSet<TransactionInTbl> TransactionInTbls { get; set; } = null!;
        public virtual DbSet<TransactionOutTbl> TransactionOutTbls { get; set; } = null!;
        public virtual DbSet<TransactionTbl> TransactionTbls { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-NG4V9TD;DataBase=WarehouseManagement;TrustServerCertificate=True;Trusted_Connection=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerTbl>(entity =>
            {
                entity.HasKey(e => e.CustomerId);

                entity.ToTable("Customer_TBL");

                entity.Property(e => e.Addres).HasColumnType("text");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Companyname).HasMaxLength(50);

                entity.Property(e => e.ContactNo).HasMaxLength(10);

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.MobileNo).HasMaxLength(10);

                entity.Property(e => e.Pssword)
                    .HasMaxLength(50)
                    .HasColumnName("pssword");

                entity.Property(e => e.State).HasMaxLength(50);
            });

            modelBuilder.Entity<LoginTbl>(entity =>
            {
                entity.HasKey(e => e.UserName);

                entity.ToTable("Login_TBL");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.MobileNo).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Pass).HasMaxLength(50);

                entity.Property(e => e.Pincode).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.UserCategory)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<ProductTbl>(entity =>
            {
                entity.HasKey(e => e.Productld);

                entity.ToTable("Product_TBL");

                entity.Property(e => e.Productld).ValueGeneratedNever();

                entity.Property(e => e.Companyname).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Hsncode).HasColumnName("HSNCode");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<SupplierTbl>(entity =>
            {
                entity.HasKey(e => e.SupplierId);

                entity.ToTable("Supplier_TBL");

                entity.Property(e => e.SupplierId).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Companyname).HasMaxLength(50);

                entity.Property(e => e.ContactNo).HasMaxLength(10);

                entity.Property(e => e.EmailId).HasMaxLength(10);

                entity.Property(e => e.MobileNo).HasMaxLength(10);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.SupplierName).HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionInTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransactionIn_TBL");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.SupplierName).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionOutTbl>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TransactionOut_TBL");

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.Unit).HasMaxLength(50);
            });

            modelBuilder.Entity<TransactionTbl>(entity =>
            {
                entity.HasKey(e => e.TransactionId);

                entity.ToTable("Transaction_TBL");

                entity.Property(e => e.TransactionId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Type).HasMaxLength(3);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
