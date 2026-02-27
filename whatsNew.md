## New Feature: Current Task Status Reading via SNPX

The SDK now provides the ability to read the current task status from the robot controller via the SNPX protocol. This allows you to monitor the execution state of programs running on different tasks.

### Property Added

- **`CurrentTaskStatus`**: Provides access to the status of running tasks on the robot controller (now public, previously private)

### What You Can Read

For each task, you can access:

- **`ProgramName`**: Name of the currently executing program
- **`LineNumber`**: Current line number being executed
- **`State`**: Execution state (Stopped, Paused, or Running)
- **`Caller`**: Name of the calling program

### Quick Example

```csharp
using UnderAutomation.Fanuc;
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.Snpx.Internal;

// Create and connect to robot
FanucRobot robot = new FanucRobot();
ConnectionParameters parameters = new ConnectionParameters("192.168.0.1");
parameters.Snpx.Enable = true;
robot.Connect(parameters);

// Read task status for task 1 (index starts from 1)
RobotTaskStatus task1Status = robot.Snpx.CurrentTaskStatus.Read(1);

// Display task information
Console.WriteLine($"Program: {task1Status.ProgramName}");
Console.WriteLine($"Line: {task1Status.LineNumber}");
Console.WriteLine($"State: {task1Status.State}");
Console.WriteLine($"Caller: {task1Status.Caller}");

// Check task state
switch (task1Status.State)
{
    case RobotTaskState.Running:
        Console.WriteLine($"Task 1 is running {task1Status.ProgramName} at line {task1Status.LineNumber}");
        break;
    case RobotTaskState.Paused:
        Console.WriteLine("Task 1 is paused");
        break;
    case RobotTaskState.Stopped:
        Console.WriteLine("Task 1 is stopped");
        break;
}

// Monitor multiple tasks
for (int i = 1; i <= 4; i++)
{
    var taskStatus = robot.Snpx.CurrentTaskStatus.Read(i);
    Console.WriteLine($"Task {i}: {taskStatus}");
}
```
