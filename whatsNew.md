## CGTP: write position into a TP program

`CgtpClient` has a new `SetProgramPosition` method. It writes a Cartesian or joint position to a given position index (P[n]) inside a TP program. Only the first motion group is supported via CGTP.

```csharp
// Cartesian position
var position = new Position(
    userFrame: 0,
    userTool: 1,
    jointsPosition: null,
    cartesianPosition: new ExtendedCartesianPosition(500, 200, 300, 0, 90, 0, 0, 0, 0)
);
robot.Cgtp.SetProgramPosition("MY_PROG", 1, position);

// Joint position
var jointPosition = new Position(
    userFrame: 0,
    userTool: 1,
    jointsPosition: new JointsPosition { J1 = 0, J2 = 0, J3 = 0, J4 = 0, J5 = -90, J6 = 0 },
    cartesianPosition: null
);
robot.Cgtp.SetProgramPosition("MY_PROG", 2, jointPosition);
```

## FTP connection timeout

The `FtpConnectParameters` class has a new `FtpTimeoutMs` property. It controls the connection, read, and data transfer timeouts for all FTP operations. The default is 30,000 ms (30 seconds).

```csharp
parameters.Ftp.Enable = true;
parameters.Ftp.FtpTimeoutMs = 10000; // 10 seconds
```

## CGTP: record current position into a program

`CgtpClient` has a new `SetProgramPositionToCurrentCartesianPosition` method. It writes the robot's current Cartesian position to a given position index inside a TP program and returns the recorded position.

```csharp
CartesianPosition pos = robot.Cgtp.SetProgramPositionToCurrentCartesianPosition("MY_PROG", 1);
Console.WriteLine($"Recorded: X={pos.X}, Y={pos.Y}, Z={pos.Z}");
```
