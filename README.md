# EEAiX Platform

A connected-device platform designed to explore the development of scalable IoT systems, from simulated devices and backend services to embedded devices, mobile connectivity, and AI agents.

## Current Focus

The project is being developed incrementally, starting with a **backend MVP** using simulated devices.

The initial MVP will allow us to:

- Register and manage devices
- Track device state
- Receive device telemetry
- Send commands to devices
- Visualize device information
- Simulate multiple connected devices

## Architecture

The project will eventually consist of four major modules:

```text
EEAiX Platform
│
├── Backend System
├── Embedded System
├── Mobile Application
└── AI Agents
```

For the initial MVP:

```text
Simulated Device
       │
       ▼
 ASP.NET Core API
       │
       ▼
   PostgreSQL
       │
       ▼
 Dashboard / CLI
```

## Technology

### Backend

- C#
- ASP.NET Core
- Entity Framework Core
- PostgreSQL
- REST API

### Simulator

- C#
- .NET

### Future

The platform will progressively explore:

- Bluetooth / BLE
- MQTT
- Redis
- Embedded C/C++/Rust
- Mobile device gateways
- Cloud infrastructure
- Distributed systems
- Kubernetes
- AI agents

## Development Philosophy

The system will be built incrementally.

Instead of introducing infrastructure prematurely, each technology will be added when a real requirement or bottleneck justifies it.

The project will evolve from:

```text
Simple MVP
    ↓
Device Simulation
    ↓
Real Device Integration
    ↓
IoT Communication
    ↓
Scaling
    ↓
Embedded Systems
    ↓
AI Agents
```

## Status

🚧 **Early Development — Backend MVP**
