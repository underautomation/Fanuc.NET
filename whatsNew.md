## Bug fix : Current position always read wrong motion group

`ReadWorldPosition()` and `ReadUserFramePosition()` were silently targeting motion group 0, which does not exist on Fanuc controllers, causing the robot to return wrong position data. Both methods now correctly default to **group 1** (the first motion group).

Multi-group robots can still target a specific group explicitly:

```csharp
// Read world position : group 1 (default, fixed)
Position pos = robot.Snpx.CurrentPosition.ReadWorldPosition();

// Read in user frame 3 : group 1 (default, fixed)
Position pos = robot.Snpx.CurrentPosition.ReadUserFramePosition(3);

// Read world position on group 2 (multi-group robots)
Position pos = robot.Snpx.CurrentPosition.ReadWorldPosition(2);

// Read in user frame 3 on group 2
Position pos = robot.Snpx.CurrentPosition.ReadUserFramePosition(3, 2);
```

---

## SNPX Numeric Registers : Int16 and Int32 support

Numeric registers (`R[]`) can now be read and written as **16-bit** or **32-bit integers** in addition to the existing float format. Two new accessors are available on the SNPX client: `NumericRegistersInt32` and `NumericRegistersInt16`.

This is useful when a Fanuc program stores integer values in numeric registers and you want to avoid float conversion artifacts.

### Single register read / write

```csharp
// Float (existing)
float  f = robot.Snpx.NumericRegisters.Read(1);
robot.Snpx.NumericRegisters.Write(1, 3.14f);

// 32-bit integer
int   i32 = robot.Snpx.NumericRegistersInt32.Read(1);
robot.Snpx.NumericRegistersInt32.Write(1, 1234567);

// 16-bit integer
short i16 = robot.Snpx.NumericRegistersInt16.Read(1);
robot.Snpx.NumericRegistersInt16.Write(1, 42);
```

### Batch read / write

Batch assignments let you read a contiguous range of registers in a single network round-trip.

```csharp
// Float (existing)
var batchF = robot.Snpx.NumericRegisters.CreateBatchAssignment(1, 10);
float[] floats = batchF.Read();

// 32-bit integer
var batchI32 = robot.Snpx.NumericRegistersInt32.CreateBatchAssignment(1, 10);
int[] ints = batchI32.Read();

// 16-bit integer
var batchI16 = robot.Snpx.NumericRegistersInt16.CreateBatchAssignment(1, 10);
short[] shorts = batchI16.Read();
```
