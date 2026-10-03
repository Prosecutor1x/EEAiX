using Platform.Domain.Enums;

namespace   Platform.Domain.Entities;

public class Device
{
    public Guid Id { get; set; }

    public string Name { get; set; } = string.Empty;

    public DeviceType Type { get; set; }

    public DeviceStatus Status { get; set; }

    public string FirmwareVersion { get; set; } = "1.0.0";

    public DateTime CreatedAt { get; set; }

    public DateTime? LastSeenAt { get; set; }
    public DeviceState? State { get; set; }
}