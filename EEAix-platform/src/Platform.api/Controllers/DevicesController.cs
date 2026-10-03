using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Platform.Application.DTOs.Devices;
using Platform.Application.Interfaces;

namespace Platform.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DevicesController : ControllerBase
    {
        private readonly IDeviceService _deviceService;

        public DevicesController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
        }

        [HttpPost]
        public async Task<ActionResult<DeviceResponse>> Create(
            CreateDeviceRequest request)
        {
            var device = await _deviceService.CreateAsync(request);

            return CreatedAtAction(
                nameof(GetById),
                new { id = device.Id },
                device);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<DeviceResponse>>> GetAll()
        {
            return Ok(await _deviceService.GetAllAsync());
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult<DeviceResponse>> GetById(Guid id)
        {
            var device = await _deviceService.GetByIdAsync(id);

            if (device is null)
                return NotFound();

            return Ok(device);
        }
    }
}