using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyStore.Entity
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<PriceRange> PriceRanges { get; set; }
        public DbSet<Goods> Goods { get; set; }

        /// <summary>
        /// 根据考试时间灵活掌握
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(opt => {
                opt.Property(m => m.UserName).HasMaxLength(50);
                opt.Property(m => m.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<Brand>(opt => {
                opt.Property(m => m.BrandName).HasMaxLength(50);
            });

            modelBuilder.Entity<Goods>(opt => {
                opt.Property(m => m.GoodsName).HasMaxLength(50);
                opt.Property(m => m.GoodsThum).HasMaxLength(500);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
