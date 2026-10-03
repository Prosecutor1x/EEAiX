using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Platform.Domain.Enums;

namespace Platform.Application.DTOs.Devices
{
    public class CreateDeviceRequest
    {
        public string Name { get; set; } = string.Empty;

        public DeviceType Type { get; set; }
    }
}