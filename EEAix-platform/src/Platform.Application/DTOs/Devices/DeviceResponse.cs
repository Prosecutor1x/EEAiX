using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platform.Domain.Enums;

namespace Platform.Application.DTOs.Devices
{
    public class DeviceResponse
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public DeviceType Type { get; set; }

        public DeviceStatus Status { get; set; }

        public string FirmwareVersion { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public DateTime? LastSeenAt { get; set; }
    }
}