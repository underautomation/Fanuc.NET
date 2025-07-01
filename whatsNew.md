- SNPX : Enable batch reading of registers and variables

```C#
NumericRegistersBatchAssignment assignment = _robot.Snpx.NumericRegisters.CreateBatchAssignment(1, 40);

float[] values = assignment.Read();
```
