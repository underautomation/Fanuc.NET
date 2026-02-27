## Bug Fixes and Improvements

This version contains a bug fix to make program startup via Telnet more robust.

### C# Usage Example

```csharp
// Run a program on the robot
var result = robot.Telnet.Run("MYPROGRAM");

if (result.Succeed)
{
    Console.WriteLine("Program started successfully");
}
else
{
    Console.WriteLine($"Error: {result.ErrorText}");
}
```
