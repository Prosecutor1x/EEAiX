using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Platform.Domain.Entities
{
    public class DeviceState
    {
        public Guid DeviceId { get; set; }

        public int Battery { get; set; }

        public double Temperature { get; set; }

        public int Volume { get; set; }

        public string Mode { get; set; } = "Normal";

        public DateTime UpdatedAt { get; set; }
    }
}