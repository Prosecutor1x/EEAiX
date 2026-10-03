using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platform.Application.DTOs.Devices;
using Platform.Application.Interfaces;
using Platform.Domain.Entities;
using Platform.Domain.Enums;


namespace Platform.Application.Services
{
    public class DeviceService : IDeviceService
    {
        // private readonly List<Device> _devices = [];
        private readonly IDeviceRepository _repository;
        public DeviceService(IDeviceRepository repository)
        {
            _repository = repository;
        }

        public async Task<DeviceResponse> CreateAsync(CreateDeviceRequest request)
        {
            var device = new Device
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Type = request.Type,
                Status = DeviceStatus.Offline,
                FirmwareVersion = "1.0.0",
                CreatedAt = DateTime.UtcNow
            };

            var state = new DeviceState
            {
                DeviceId = device.Id,
                Battery = 100,
                Temperature = 25.0,
                Volume = 50,
                Mode = "Normal",
                UpdatedAt = DateTime.UtcNow
            };

            device.State = state;

            var createdDevice = await _repository.AddAsync(device);

            return MapToResponse(createdDevice);


        }
        public async Task<IEnumerable<DeviceResponse>> GetAllAsync()
        {
            var devices = await _repository.GetAllAsync();

            return devices.Select(MapToResponse);
        }

        public async Task<DeviceResponse?> GetByIdAsync(Guid id)
        {
            var device = await _repository.GetByIdAsync(id);

            return device is null ? null : MapToResponse(device);
        }

        private static DeviceResponse MapToResponse(Device device)
        {
            return new DeviceResponse
            {
                Id = device.Id,
                Name = device.Name,
                Type = device.Type,
                Status = device.Status,
                FirmwareVersion = device.FirmwareVersion,
                CreatedAt = device.CreatedAt,
                LastSeenAt = device.LastSeenAt,



                State = device.State is null
                ? null
                : new DeviceStateResponse
                {
                    Battery = device.State.Battery,
                    Temperature = device.State.Temperature,
                    Volume = device.State.Volume,
                    Mode = device.State.Mode,
                    UpdatedAt = device.State.UpdatedAt
                }
            };
        }
    }
}