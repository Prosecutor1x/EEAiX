using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platform.Application.DTOs.Devices;

namespace Platform.Application.Interfaces
{
    public interface IDeviceService
    {
        Task<DeviceResponse> CreateAsync(CreateDeviceRequest request);

        Task<IEnumerable<DeviceResponse>> GetAllAsync();

        Task<DeviceResponse?> GetByIdAsync(Guid id);
    }
}