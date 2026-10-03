using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Platform.Application.Interfaces;
using Platform.Domain.Entities;
using Platform.Infrastructure.Data;


namespace Platform.Infrastructure.Repositories
{
    public class PostGresDeviceRepository : IDeviceRepository
    {
        private readonly PlatformDbContext _dbContext;

        public PostGresDeviceRepository(PlatformDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Device> AddAsync(Device device)
        {
            await _dbContext.Devices.AddAsync(device);
            await _dbContext.SaveChangesAsync();

            return device;
        }

        public async Task<IEnumerable<Device>> GetAllAsync()
        {
            return await _dbContext.Devices
           .AsNoTracking()
           .ToListAsync();
        }

        public async Task<Device?> GetByIdAsync(Guid id)
        {
            return await _dbContext.Devices
            .Include(d => d.State)
            .AsNoTracking()
            .FirstOrDefaultAsync(d => d.Id == id);
        }
    }


}
