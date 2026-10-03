using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platform.Domain.Entities;

namespace Platform.Application.Interfaces
{
    public interface IDeviceRepository
    {
        Task<Device> AddAsync(Device device);

        Task<IEnumerable<Device>> GetAllAsync();

        Task<Device?> GetByIdAsync(Guid id);
    }
}