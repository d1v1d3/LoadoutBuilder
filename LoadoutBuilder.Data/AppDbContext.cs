using LoadoutBuilder.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadoutBuilder.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WeaponCamo>()
                .HasKey(wc => new { wc.WeaponId, wc.CamoId });
        }
        public DbSet<Loadout> Loadouts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Weapon> Weapons { get; set; }
        public DbSet<Camo> Camos { get; set; }
        public DbSet<WeaponCamo> WeaponCamos { get; set; }
    }
}
