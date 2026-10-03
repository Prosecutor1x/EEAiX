using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platform.Application.Interfaces;
using Platform.Domain.Entities;


namespace Platform.Infrastructure.Repositories
{
    public class InMemoryDeviceRepository : IDeviceRepository
    {
        private readonly List<Device> _devices = [];

        public Task<Device> AddAsync(Device device)
        {
            _devices.Add(device);

            return Task.FromResult(device);
        }

        public Task<IEnumerable<Device>> GetAllAsync()
        {
            return Task.FromResult(
                _devices.AsEnumerable()
            );
        }

        public Task<Device?> GetByIdAsync(Guid id)
        {
            return Task.FromResult(
                _devices.FirstOrDefault(d => d.Id == id)
            );
        }
    }
}