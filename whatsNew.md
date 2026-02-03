## Bug Fixes

- **Telnet Run command**: Fixed false error reporting after calling method `Run` and program running successfully

## New Features

### SNPX Flags Support

Read and write robot flags via SNPX protocol:

```csharp
// Read/write single flag
bool flag6 = robot.Snpx.Flags.Read(6);
robot.Snpx.Flags.Write(6, true);

// Batch read multiple flags
var assignment = robot.Snpx.Flags.CreateBatchAssignment(startIndex: 5, count: 10);
bool[] values = assignment.Read();
```

### Batch Assignments with Start Index

`NumericRegisters`, `PositionRegisters`, `StringRegisters`, and `Flags` now support `CreateBatchAssignment(startIndex, count)` for efficient bulk operations without having to specify each index individually in the other overloads of `CreateBatchAssignment`.
