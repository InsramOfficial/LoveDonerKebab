﻿using WebApplication1.Models;
using MessagePack;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication1.Data
{
    public class DataDbContext : DbContext
    {
        public DataDbContext(DbContextOptions<DataDbContext> options) : base(options)
        {
        }

        public DbSet<Category> categories { get; set; }
        public DbSet<Inv_Items> items { get; set; }
        public DbSet<Sales> sales { get; set; }
        public DbSet<SoldItems> soldItems { get; set; }
        public DbSet<BankSattlement> bankSattlements { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<Register> logins { get; set; }
        public DbSet<Method> methods { get; set; }
        public DbSet<CartItems> CartItems { get; set; }
        public DbSet<UserPermissions> userPermissions { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SoldItems>(entity =>
            {
                entity.Property(e => e.SaleId)
                      .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ItemId)
                      .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnitPrice)
                      .HasColumnType("decimal(18, 1)");

                entity.Property(e => e.NetPrice)
                      .HasColumnType("decimal(18, 0)");

                // If needed, continue with other property configurations here.
            });
        }


    }
}