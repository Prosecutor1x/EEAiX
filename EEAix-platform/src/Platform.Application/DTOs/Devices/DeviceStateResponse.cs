using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Application.DTOs.Devices
{
    public class DeviceStateResponse
    {
        public int Battery { get; set; }

        public double Temperature { get; set; }

        public int Volume { get; set; }

        public string Mode { get; set; } = string.Empty;

        public DateTime UpdatedAt { get; set; }
    }
}