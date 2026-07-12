## RMI: complete API rewrite

The RMI client has been redesigned from scratch. The previous method-per-instruction API is replaced by an instruction object model that is easier to extend and closer to how the controller actually works.

### Instruction pipeline

Each call to `SendTpInstruction` now returns an `RmiInstructionResponse` that you can poll or block on:

```csharp
RmiInstructionResponse r = robot.Rmi.SendTpInstruction(new LinearMotionTpInstruction
{
    SpeedType = RmiLinearSpeedType.MmSec,
    Speed = 100,
    TermType = RmiTerminationType.Fine,
    Target = new CartesianPositionWithUserFrame(500, 200, 300, 0, 90, 0, 1, 0)
});

// Wait for the controller to confirm execution
r.WaitForCompletion();
Console.WriteLine(r.Status); // Completed or Error
```

The client manages the 8-slot controller buffer automatically. Instructions that exceed the limit are held in a local queue and sent as soon as a slot becomes free.

### New instruction classes

All instruction types now have dedicated classes:

| Class                             | TP equivalent                                   |
| --------------------------------- | ----------------------------------------------- |
| `LinearMotionTpInstruction`       | `L P[] mm/sec FINE`                             |
| `LinearRelativeTpInstruction`     | `L P[] mm/sec FINE INC`                         |
| `JointMotionTpInstruction`        | `J P[] % FINE`                                  |
| `JointRelativeTpInstruction`      | `J P[] % FINE INC`                              |
| `CircularMotionTpInstruction`     | `C P[] P[] mm/sec FINE`                         |
| `CircularRelativeTpInstruction`   | `C P[] P[] mm/sec FINE INC`                     |
| `LinearMotionJRepTpInstruction`   | `L P[] mm/sec FINE` (joint-angle target)        |
| `LinearRelativeJRepTpInstruction` | incremental, joint-angle target                 |
| `JointMotionJRepTpInstruction`    | `J P[] % FINE` (joint-angle target)             |
| `JointRelativeJRepTpInstruction`  | incremental, joint-angle target                 |
| `SplineMotionTpInstruction`       | `S P[] mm/sec CNT` (requires MajorVersion >= 7) |
| `SplineMotionJRepTpInstruction`   | spline, joint-angle target                      |
| `WaitDinTpInstruction`            | `WAIT DI[n] = ON/OFF`                           |
| `WaitTimeTpInstruction`           | `WAIT t(sec)`                                   |
| `SetUFrameTpInstruction`          | `UFRAME_NUM = n`                                |
| `SetUToolTpInstruction`           | `UTOOL_NUM = n`                                 |
| `SetPayloadTpInstruction`         | `PAYLOAD[n]`                                    |
| `CallProgramTpInstruction`        | `CALL program`                                  |

### New admin methods

- `Initialize(groupMask, rtsa, pltzMode)`: starts RMI_MOVE with optional multi-group, singularity avoidance, and palletizing header support.
- `AutoSetNextSequenceId()`: reads `GetStatus()` and re-synchronizes the local sequence counter when the controller checks sequence IDs.
- `GetExtendedStatus()`: returns drive state, control mode, and speed clamp.
- `ReadNumericRegister` / `WriteNumericRegisterAsInteger` / `WriteNumericRegisterAsDouble`: read and write numeric registers (R[]).
- `ReadVariable` / `WriteVariableAsInteger` / `WriteVariableAsDouble`: read and write system variables.
- `SetPayloadValue(...)`: define payload mass and center of gravity for a schedule.
- `SetPayloadCompensation(...)`: define payload compensation.
- `SetPayloadSchedule(scheduleNumber)`: activate a payload schedule immediately (command, not instruction).
- `ReadIOPort` / `WriteIOPort`: read and write any IO port type (DI, DO, AI, AO, GO, RO, FLAG, RI, UI, UO).
- `ClearCompletedInstructions()` / `ClearLocalQueuedInstructions()`: manage the tracked instruction list.

### New events

- `ConnectionTerminated`: fired when the controller closes the session.
- `SystemFaultReceived`: fired on a controller fault; argument is the faulted sequence ID.
- `RecordedCartesianPositionReceived` / `RecordedJointPositionReceived`: fired when the RMI Position Record menu sends a position.

### Hold state detection

`IsInHoldState` is now a property. The client sets it automatically when the controller returns status "HOLD" or error "invalid sequence ID". Call `Reset()` to exit the hold state.

---

## FTP: FtpExistsBehavior on upload methods

`UploadFileToController` now accepts a `FtpExistsBehavior` parameter:

```csharp
robot.Ftp.DirectFileHandling.UploadFileToController(
    @"C:\Programs\MyPrg.tp",
    "md:/MyPrg.tp",
    existsBehavior: FtpExistsBehavior.Skip);
```

| Value           | Behavior                                                                 |
| --------------- | ------------------------------------------------------------------------ |
| `NoCheck`       | Skip existence check. Use only when the file is guaranteed not to exist. |
| `Skip`          | Do nothing if the file already exists.                                   |
| `Overwrite`     | Replace the file (default).                                              |
| `Append`        | Resume a partial upload by checking the current file size.               |
| `AppendNoCheck` | Append without checking whether the file exists first.                   |

---

## CGTP: fix file download on some controllers

Fixed a bug where downloading files via CGTP could fail or return incomplete data on controllers that close the HTTP connection before sending the end-of-response marker. The response body is now fully buffered before the connection is released.
