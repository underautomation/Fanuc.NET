## Stream Motion (J519) Support

Added support for Fanuc's **Stream Motion** option (J519), enabling real-time streaming motion control over UDP.

### Features

- **Real-time streaming** at 125Hz or 250Hz (controller dependent)
- **Joint and Cartesian** motion modes
- **Position feedback** with motor currents at ~500Hz
- **I/O read/write** capabilities during motion
- **Axis threshold queries** for velocity, acceleration, and jerk limits
- Support for **Group 1 (robot) + up to 3 auxiliary axes**

### Key Classes

- `StreamMotionClient` - Main client for connection and streaming
- `StatePacket` - Robot state with position, status, and motor currents
- `CommandPacket` - Motion commands with I/O operations
- `RobotStatus` - Status flags (ReadyForCommands, InMotion, CommandReceived, SystemReady)

### Usage

```csharp
var client = new StreamMotionClient();
client.Connect("192.168.1.1");
client.StateReceived += (s, e) => {
    // Send next interpolated position when ready
    if (e.State.Status.ReadyForCommands && !e.State.Status.InMotion)
    {
        client.SendJointCommand(new MotionData { J1 = 10, J2 = 20 });
    }
};
client.Start();
```

### Important Notes

- Requires J519 option on the controller
- A TP program with `IBGN Start[]` / `IBGN End[]` must be running on the robot
- **You must implement your own motion interpolator** - jumping to target positions will cause jerk limit errors
- Not all robot models are supported - verify compatibility before use
