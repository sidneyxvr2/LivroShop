﻿using LivroShop.ApplicationCore.Entities;
using LivroShop.Infrastructure.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace LivroShop.Infrastructure.Data
{
    public class LivroShopContext : DbContext
    {
        public LivroShopContext(DbContextOptions<LivroShopContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new LivroConfig());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Livro> Livros { get; set; }
    }
}
