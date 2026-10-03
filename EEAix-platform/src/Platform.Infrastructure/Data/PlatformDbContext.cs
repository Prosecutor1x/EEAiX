using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Platform.Domain.Entities;


namespace Platform.Infrastructure.Data
{
    public class PlatformDbContext : DbContext
    {
        public PlatformDbContext(DbContextOptions<PlatformDbContext> options) : base(options)
        {
        }

        public DbSet<Device> Devices { get; set; } = null!;
        public DbSet<DeviceState> DeviceStates => Set<DeviceState>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DeviceState>()
                .HasKey(x => x.DeviceId);

            modelBuilder.Entity<Device>()
                .HasOne(x => x.State)
                .WithOne()
                .HasForeignKey<DeviceState>(x => x.DeviceId);
        }
    }
}