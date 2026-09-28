# Fanuc Communication SDK

[![UnderAutomation Fanuc communication SDK](https://raw.githubusercontent.com/underautomation/Fanuc.NET/refs/heads/main/.github/assets/banner.png)](https://underautomation.com)

[![NuGet](https://img.shields.io/nuget/dt/UnderAutomation.Fanuc?label=NuGet%20Downloads&logo=nuget)](https://www.nuget.org/packages/UnderAutomation.Fanuc/)
[![.NET Framework](https://img.shields.io/badge/.NET_Framework-3.5+-blueviolet)](#)
[![.NET Standard](https://img.shields.io/badge/.NET_Standard-2.0+-blueviolet)](#)
[![.NET Core](https://img.shields.io/badge/.NET_Core-2.0+-blueviolet)](#)
[![.NET Versions](https://img.shields.io/badge/.NET-5_6_8_9-blueviolet)](#)

### 🤖 Effortlessly Communicate with Fanuc robots

The **Fanuc SDK** enables seamless integration with Fanuc robots for automation, data exchange, and remote control. Ideal for industrial automation, research, and advanced robotics applications.

It allows you to connect to a **real robot**, but also to **ROBOGUIDE**.

🔗 **More Information:** [https://underautomation.com/fanuc](https://underautomation.com/fanuc)  
🔗 Also available for **[🟨 LabVIEW](https://github.com/underautomation/Fanuc.vi)** & **[🐍 Python](https://github.com/underautomation/Fanuc.py)**

---

[⭐ Star if you like it !](https://github.com/underautomation/Fanuc.NET/stargazers)

[👁️ Watch to be notified of latest updates !](https://github.com/underautomation/Fanuc.NET/watchers)

---

## 🚀 TL;DR (Too Long; Didn’t Read)

- ✔️ **PCDK Alternative:** No need for Fanuc’s PCDK or Robot Interface
- 📖 **Read/Write Variables:** Access and modify system variables.
- 🔄 **Register Control:** Read/write registers for positions, numbers, and strings.
- 🎬 **Program Control:** Run, abort, and reset programs.
- 🔔 **Alarm Management:** Reset alarms and view alarm history.
- ⚡ **I/O Control:** Manage ports and I/O values (UI, UO, GI, GO, etc.).
- 🔍 **State Monitoring:** Get safety status, position, diagnostics, and more.
- 📂 **File Management:** Easily manipulate files.
- 🌐 **CGTP Web Server:** Access registers, I/O, programs, and variables via HTTP.
- 🏎️ **Remote motion:** Remote move the robot.
- 🔄 **Stream Motion:** Real-time motion at every communication cycle (option J519): trajectories, target tracking, I/O.
- 🛤️ **Motion Planner:** Smooth jerk limited trajectories offline (J, L, C, CNT, CR, splines, shapes).
- 📐 **Kinematics Calculations:** Perform forward and inverse kinematics offline.

Nothing has to be installed on the robot, and most features work without any Fanuc option. For advanced uses, if your controller has the RMI (R912), Stream Motion (J519) or HMI Device SNPX (R553) option, the SDK can use it too.

---

## 📥 Download Example Applications

Explore the **Fanuc SDK** with fully functional example applications and precompiled binaries for various platforms. [See Github releases](https://github.com/underautomation/Fanuc.NET/releases)

### 🔹 Windows Forms Application (Full Feature Showcase)

A Windows Forms application demonstrating all the features of the library.

📌 **Download:** [📥 UnderAutomation.Fanuc.Showcase.Forms.exe](https://github.com/underautomation/Fanuc.NET/releases/latest/download/UnderAutomation.Fanuc.Showcase.Forms.exe)

---

**Read variables :**

![](https://raw.githubusercontent.com/underautomation/Fanuc.NET/refs/heads/main/.github/assets/read-variables.gif)

---

**Move the robot :**

![](https://raw.githubusercontent.com/underautomation/Fanuc.NET/refs/heads/main/.github/assets/move-robot.gif)

---

**High speed Read & Write registers :**
![](https://raw.githubusercontent.com/underautomation/Fanuc.NET/refs/heads/main/.github/assets/snpx.gif)

---

**Live remote control with Jostick or 3D Mouse:**
![](https://raw.githubusercontent.com/underautomation/Fanuc.NET/refs/heads/main/.github/assets/dpm-mouse-control.gif)

---

**TP Editor with breakpoints:**
![](https://raw.githubusercontent.com/underautomation/Fanuc.NET/refs/heads/main/.github/assets/tp-editor-breakpoints.gif)

---

**Forward and Inverse Kinematics:**
![](https://raw.githubusercontent.com/underautomation/Fanuc.NET/refs/heads/main/.github/assets/forward-inverse-kinematics.png)

---

## 📌 Features

### 🖥️ **1. Remote Control via Telnet KCL**

Telnet KCL (Keyboard Command Line) allows sending commands to control the robot **remotely**:no additional options needed on the controller.

#### 🔹 Reset alarms

```csharp
robot.Telnet.Reset();
```

#### 🔹 Start, pause, hold, abort programs

```csharp
robot.Telnet.Run("MyProgram");
robot.Telnet.Pause("MyProgram");
robot.Telnet.Hold("MyProgram");
robot.Telnet.Continue("MyProgram");
robot.Telnet.Abort("MyProgram", force: true);
```

#### 🔹 Set variables dynamically

```csharp
robot.Telnet.SetVariable("my_variable", 42);
robot.Telnet.SetVariable("$RMT_MASTER", 1);
```

#### 🔹 Control robot I/O ports

```csharp
// Set an output port (example: DOUT port 2 = 0)
robot.Telnet.SetPort(KCLPorts.DOUT, 2, 0);

// Simulate an input port (example: DIN port 3 = 1)
robot.Telnet.Simulate(KCLPorts.DIN, 3, 1);
robot.Telnet.Unsimulate(KCLPorts.DIN, 3);
```

---

### 🚀 **2. High-Speed Data Exchange via SNPX (RobotIF)**

SNPX (also known as **SRTP/RobotIF**) enables fast, structured data communication with the robot.  
It is used to **read/write registers, monitor alarms, and check robot status**.

#### 🔹 Read & write position registers

```csharp
// Read position register 1
Position register1 = robot.Snpx.PositionRegisters.Read(1);

// Write a Cartesian position to register 2
robot.Snpx.PositionRegisters.Write(2, new CartesianPosition { X = 100, Y = 50, Z = 25, W = 180, P = 0, R = 0 });
```

#### 🔹 Read & write numeric registers

```csharp
// Read register R[1]
float value = robot.Snpx.NumericRegisters.Read(1);

// Write a value to R[2]
robot.Snpx.NumericRegisters.Write(2, 123.45f);
```

#### 🔹 Read and control robot signals (UI, UO, GI, GO)

```csharp
// Read a User Input (UI) state
bool UI1 = robot.Snpx.UI.Read(1);

// Set a User Output (UO) signal
robot.Snpx.UO.Write(3, true);
```

#### 🔹 Read & write variables

```csharp
// Write a system variable
robot.Snpx.IntegerSystemVariables.Write("$RMT_MASTER", 1);
robot.Snpx.StringSystemVariables.Write("$ALM_IF.$LAST_ALM", "No alarms");
robot.Snpx.PositionSystemVariables.Write("$CELL_FLOOR", cellFloor);

// Write a Karel program variable
robot.Snpx.IntegerSystemVariables.Write("$[KarelProgram]KarelVariable", 1);
```

#### Clear alarms

```csharp
// Clear alarms
robot.Snpx.ClearAlarms();
```

#### Get current position

```csharp
// Read current joint and cartesian position
Position position = robot.Snpx.CurrentPosition.ReadWorldPosition();

// Read User frame cartesian position
robot.Snpx.CurrentPosition.ReadUserFramePosition(1);
```

---

### 📂 **3. File & Variable Management via FTP Memory Access**

The SDK provides **direct FTP access** to the robot's memory for **file transfer, variable reading, and configuration management**.

#### 🔹 Upload, download, and delete files

```csharp
// Upload a TP program to the controller
robot.Ftp.DirectFileHandling.UploadFileToController(@"C:\Programs\MyPrg.tp", "md:/MyPrg.tp");

// Download a file from the robot
robot.Ftp.DirectFileHandling.DownloadFileFromController(@"C:\Backup\Backup.va", "md:/Backup.va");

// Delete a file on the robot
robot.Ftp.DirectFileHandling.DeleteFile("md:/OldProgram.tp");
```

#### 🔹 Read all declared variables

```csharp
var allVariables = robot.Ftp.GetAllVariables();
foreach (var variable in allVariables)
{
    Console.WriteLine($"{variable.Name} = {variable.Value}");
}
```

#### 🔹 Read known system variables

```csharp
// Read system variable $RMT_MASTER
int remoteMode = robot.Ftp.KnownVariableFiles.GetSystemFile().RmtMaster;
```

#### 🔹 Check robot safety status

```csharp
SafetyStatus safetyStatus = robot.Ftp.GetSafetyStatus();
Console.WriteLine($"Emergency Stop: {safetyStatus.ExternalEStop}");
Console.WriteLine($"Teach Pendant Enabled: {safetyStatus.TPEnable}");
```

#### 🔹 Retrieve the robot's current position

```csharp
CurrentPosition currentPosition = robot.Ftp.GetCurrentPosition();
GroupPosition group = currentPosition.GroupsPosition[0];
Console.WriteLine($"Cartesian Position: X={group.WorldPositions[0].X}, Y={group.WorldPositions[0].Y}, Z={group.WorldPositions[0].Z}");
Console.WriteLine($"Joint Position: J1={group.JointsPosition.J1}, J2={group.JointsPosition.J2}");
```

---

## 🔧 Configuration

### ✅ **Enable Telnet KCL**

1. **Go to** `SETUP > Host Comm`
2. **Select** `TELNET` and press `[DETAIL]`
3. **Set a password** and restart the robot

### ✅ **Enable FTP Memory Access**

1. **Go to** `SETUP > Host Comm > FTP`
2. **Set a username & password**
3. **Perform a cold start**

### ✅ **Enable SNPX**

- If Your Robot Uses "FANUC America Corp." Parameters (R650 FRA):
  You need to enable option R553 ("HMI Device SNPX") in the robot's software configuration.

- If Your Robot Uses "FANUC Ltd." Parameters (R651 FRL):
  No additional option is required:SNPX is included by default.

### ✅ **Enable Stream Motion**

1. **Check** that option **J519 Stream Motion** is installed (`Features.HasStreamMotion`)
2. **Set** `$PARAM_GROUP[1].$SV_OFF_ENB[*]` to `FALSE`
3. **Run** a TP program with `IBGN start[1]` and `IBGN end[1]`, in AUTO mode at 100% override

Full tutorial: [underautomation.com/fanuc/documentation/stream-motion](https://underautomation.com/fanuc/documentation/stream-motion)

### 🌐 **4. CGTP Web Server Protocol**

CGTP communicates with the robot controller's **built-in HTTP web server**. It provides a comprehensive API for program management, variable access, register operations, I/O control, and kinematics.

#### 🔹 Read & write variables

```csharp
string value = robot.Cgtp.ReadVariableAsString("$MCR.$GENOVERRIDE");
robot.Cgtp.WriteVariable("$MCR.$GENOVERRIDE", 50);
```

#### 🔹 Register access

```csharp
// Numeric registers
robot.Cgtp.WriteNumericRegisterAsInteger(1, 42);
var reg = robot.Cgtp.ReadNumericRegisterWithComment(1);

// String registers
robot.Cgtp.WriteStringRegister(1, "Hello CGTP");
```

#### 🔹 Program control

```csharp
robot.Cgtp.SelectProgram("MAIN", 1);
robot.Cgtp.RunProgram("MAIN");
robot.Cgtp.PauseAllPrograms();
robot.Cgtp.AbortTask("MAIN");
```

#### 🔹 List programs

```csharp
// List all TP programs on the controller
string[] allTp = robot.Cgtp.ListTpPrograms();

// List Karel macros only
string[] macros = robot.Cgtp.ListPrograms(CgtpProgramType.Karel, CgtpProgramSubType.Macro);
```

#### 🔹 Source code editing (firmware V9.10+)

```csharp
// Insert a line before line 3
robot.Cgtp.InsertSourceLine("MY_PROGRAM", "L P[5] 100mm/sec FINE", 3);

// Replace line 5
robot.Cgtp.ReplaceSourceLine("MY_PROGRAM", "J P[1] 50% FINE", 5);

// Delete 2 lines starting at line 4
robot.Cgtp.DeleteSourceLines("MY_PROGRAM", 4, 2);
```

#### 🔹 Write position data into a program (firmware V9.10+)

`SetProgramPosition` writes a Cartesian or joint position to a position index P[n] inside a TP program. Only the first motion group is supported via CGTP.

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

#### 🔹 I/O control

```csharp
int ioValue = robot.Cgtp.ReadIo(CgtpIoPortType.DO, 1);
robot.Cgtp.WriteIo(CgtpIoPortType.DO, 1, 1);
robot.Cgtp.SimulateIo(CgtpIoPortType.DI, 3);
robot.Cgtp.UnsimulateIo(CgtpIoPortType.DI, 3);
```

---

### 🔄 **5. Stream Motion (J519): Real-Time Motion**

Stream Motion (option **J519**) gives the position of the robot at every communication cycle (2 to 8 ms). The SDK does the real-time part for you: it synchronizes the positions with the status of the robot, sends a few positions in advance, and stops the robot smoothly if your application stops giving positions.

The robot must run a TP program with `IBGN start[1]` and `IBGN end[1]`, in AUTO mode at 100% override.

#### 🔹 Connect and read the status

```csharp
var parameters = new ConnectionParameters("192.168.0.1");
parameters.StreamMotion.Enable = true;
parameters.StreamMotion.ProtocolVersion = 1; // 1, 2 or 3, not higher than $STMO.$USABLE_VER
robot.Connect(parameters);

// Read the limits of the robot, start the status output and measure the communication cycle
robot.StreamMotion.StartMonitoring();

StreamMotionStatus status = robot.StreamMotion.LastStatus;
Console.WriteLine($"J1={status.JointPosition.J1:F3}° Moving={status.IsMoving}");
```

#### 🔹 Send trajectories

```csharp
var sm = robot.StreamMotion;
var planner = new MotionPlanner(sm.JointLimits, null);

// J1 +10 degrees then back, at 20% of the velocity limits
JointsPosition start = sm.QueueEndJointPosition;
var target = new JointsPosition(start.Values) { J1 = start.J1 + 10 };
Trajectory trajectory = planner.CreateJointPath(start)
    .MoveJoint(target, 20, Termination.Cnt(100))
    .MoveJoint(start, 20, Termination.Fine())
    .Build();

// The motion starts when the TP program reaches IBGN start
int motionId = sm.Enqueue(trajectory);
sm.WaitForMotion(motionId, 60000);

// Release the TP program: it continues after IBGN end
sm.Finish(10000);
```

`Override`, `Pause()`, `Resume()` and `Abort()` slow down or stop the trajectories smoothly on their path.

#### 🔹 Follow a target in real time

```csharp
// The robot goes to the last target, at 30% of its velocity limits
sm.StartTracking(PositionFormat.Joint, 30);
sm.SetJointTrackingTarget(new JointsPosition(start.Values) { J1 = start.J1 + 10 });
sm.WaitForIdle(10000);
sm.StopTracking();
```

To compute the position yourself at every cycle, handle the `SetpointRequested` event and call `StartCallbackStreaming()`.

#### 🔹 I/O during motion

```csharp
sm.AddIOMonitor(IOType.DI, 1);      // read DI[1] to DI[16] during the session
bool di3 = sm.GetIO(IOType.DI, 3);
sm.WriteIO(IOType.DO, 1, true);     // written with the next position sent
```

📖 [Stream Motion documentation](https://underautomation.com/fanuc/documentation/stream-motion)

---

### 🏎️ **6. Remote Motion via RMI**

RMI (Remote Motion Interface, option R912) lets you send TP-equivalent motion instructions to the robot in real time. The client manages the controller instruction buffer automatically and returns a response object per instruction.

#### 🔹 Robot setup required

The controller must have the **Remote Motion Interface (R912)** option. The bootstrap port is **16001** (TCP). The teach pendant must be disabled and the controller must be in AUTO mode before calling `Initialize()`.

#### 🔹 Connect and initialize

```csharp
var parameters = new ConnectionParameters("192.168.0.1");
parameters.Rmi.Enable = true;
robot.Connect(parameters);

// Start the RMI_MOVE TP program on the controller
robot.Rmi.Initialize();
```

#### 🔹 Send motion instructions

```csharp
using UnderAutomation.Fanuc.Common;
using UnderAutomation.Fanuc.Rmi.Data;
using UnderAutomation.Fanuc.Rmi.TpInstructions;

// Linear motion to a Cartesian target
var instr = new LinearMotionTpInstruction
{
    SpeedType = RmiLinearSpeedType.MmSec,
    Speed = 100,
    TermType = RmiTerminationType.Fine,
    Target = new CartesianPositionWithUserFrame(500, 200, 300, 0, 90, 0, tool: 1, frame: 0)
};

RmiInstructionResponse r = robot.Rmi.SendTpInstruction(instr);

// Optional: wait for the instruction to complete
r.WaitForCompletion();
if (r.Status == RmiInstructionStatus.Error)
    Console.WriteLine("Error: " + r.ErrorText);
```

#### 🔹 Joint motion with joint-angle target

```csharp
var jrep = new JointMotionJRepTpInstruction
{
    SpeedType = RmiJointSpeedType.Percent,
    Speed = 10,
    TermType = RmiTerminationType.Fine,
    Joints = new JointsPosition(10, -20, 30, 0, 60, 0)
};
robot.Rmi.SendTpInstruction(jrep);
```

#### 🔹 Circular motion

```csharp
var arc = new CircularMotionTpInstruction
{
    SpeedType = RmiLinearSpeedType.MmSec,
    Speed = 80,
    TermType = RmiTerminationType.Fine,
    Via = new CartesianPositionWithUserFrame(600, 100, 350, 0, 90, 0, 1, 0),   // arc via-point
    Target = new CartesianPositionWithUserFrame(700, 0, 300, 0, 90, 0, 1, 0)   // destination
};
robot.Rmi.SendTpInstruction(arc);
```

#### 🔹 Non-motion instructions

```csharp
// Wait for digital input
robot.Rmi.SendTpInstruction(new WaitDinTpInstruction { PortNumber = 1, Value = RmiOnOff.ON });

// Time delay
robot.Rmi.SendTpInstruction(new WaitTimeTpInstruction { Seconds = 0.5 });

// Activate a payload schedule
robot.Rmi.SendTpInstruction(new SetPayloadTpInstruction { ScheduleNumber = 1 });

// Call a TP program (requires MajorVersion >= 4)
robot.Rmi.SendTpInstruction(new CallProgramTpInstruction { ProgramName = "MY_PROG" });
```

#### 🔹 Admin commands

```csharp
// Check controller status before initializing
var status = robot.Rmi.GetStatus();

// Set speed override
robot.Rmi.SetOverride(50);

// Read current position
var pos = robot.Rmi.ReadCartesianPosition();
var joints = robot.Rmi.ReadJointAngles();

// Abort the RMI_MOVE program when done
robot.Rmi.Abort();
```

---

## 📐 **Kinematics Calculations:**

The SDK includes tools for performing forward and inverse kinematics calculations offline, allowing you to compute the robot's end-effector position based on joint angles and vice versa, from DH parameters.

```csharp
using UnderAutomation.Fanuc.Kinematics;

JointsPosition position = new JointsPosition(10, 20, 120, 0, 0, 25);

// ---- Get DH parameters ----
// Example: CRX-10iA/L
DhParameters dh = new DhParameters(-540, 150, -160, 0, 710, 0);

// From a known arm model
dh = DhParameters.FromArmKinematicModel(ArmKinematicModels.CRX10iA);

// From OPW parameters: M10iA/7L
dh = DhParameters.FromOpwParameters(0.15, -0.20, 0.60, 0.86, 0.10);

// From an online robot (SYSMOTN file)
dh = DhParameters.FromSymotnFile(robot.Ftp.KnownVariableFiles.GetSymotnFile())[0];

// ---- Forward kinematics ----
CartesianPosition pose = KinematicsUtils.ForwardKinematics(position, dh);

// ---- Inverse kinematics with multiple solutions ----
JointsPosition[] positions = KinematicsUtils.InverseKinematics(pose, dh);
```

---

## 🛤️ **Motion Planner:**

The `UnderAutomation.Fanuc.Motion` namespace creates smooth trajectories offline, within velocity, acceleration and jerk limits. Motions are described as in a TP program: J, L and C motions with FINE, CNT or CR termination. Trajectories can be sent with Stream Motion, sampled for a simulation, or checked against the limits of the robot.

```csharp
using UnderAutomation.Fanuc.Motion;

// Limits of each axis: read them with robot.StreamMotion.ReadLimits().ReferenceLimits
var jointLimits = new JointLimits(
    new double[] { 120, 120, 180, 180, 180, 180 },         // velocity, deg/s
    new double[] { 300, 300, 450, 675, 675, 675 },         // acceleration, deg/s2
    new double[] { 1125, 1125, 1687, 2530, 1265, 2530 });  // jerk, deg/s3
var cartesianLimits = new CartesianLimits(500, 2000, 10000, 90, 360, 1800);
var planner = new MotionPlanner(jointLimits, cartesianLimits);

// J P[1] 50% CNT100, J P[2] 50% FINE
var home = new JointsPosition(0, 0, 0, 0, -90, 0);
var pick = new JointsPosition(30, 20, -10, 0, -70, 30);
Trajectory joint = planner.CreateJointPath(home)
    .MoveJoint(pick, 50, Termination.Cnt(100))
    .MoveJoint(home, 50, Termination.Fine())
    .Build();

// L 200mm/sec CR10, then a circle of radius 30 mm at 150 mm/s
var plane = new XYZWPRPosition(600, 0, 250, 0, 0, 0); // origin = center of the circle
Trajectory cartesian = planner.CreateCartesianPath(new XYZWPRPosition(500, 0, 300, 180, 0, 0))
    .MoveLinear(new XYZWPRPosition(600, 0, 300, 180, 0, 0), 200, Termination.Cr(10))
    .AddCircle(plane, 30, 150, Termination.Fine())
    .Build();

// Duration, position at any time, one position per cycle
Console.WriteLine($"Duration: {joint.Duration:0.000} s");
JointsPosition[] samples = joint.SampleJoints(0.008);

// Velocity, acceleration and jerk of each axis, computed as the robot does
TrajectoryReport report = joint.Check(jointLimits, 0.008, false);
```

The planner also creates splines (`MoveSpline()`, `MoveJointSpline()`), shapes (`AddRectangle()`, `AddPolygon()`, `AddHelix()`, `AddSpiral()`), and trajectories from your own positions (`Trajectory.FromJointSamples()`, `Trajectory.FromTimedJoints()`...). `XYZWPRPosition` gives quaternions (`GetQuaternion()`) and frame changes (`FlangeToTcp()`, `WorldToUserFrame()`...).

📖 [Motion planner documentation](https://underautomation.com/fanuc/documentation/motion)

---

## 🛠 Installation

### 1️⃣ **Get the SDK**

Choose the installation method that works best for you:

| Method             | NuGet (Recommended)                                                                     | Direct Download                                                                                                    |
| ------------------ | --------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------ |
| **How to Install** | Install via NuGet. [See on Nuget](https://www.nuget.org/packages/UnderAutomation.Fanuc) | Download and reference the DLL manually                                                                            |
|                    | `dotnet add package UnderAutomation.Fanuc `                                             | 📥 [Download ZIP](https://github.com/underautomation/Fanuc.NET/releases/latest/download/UnderAutomation.Fanuc.zip) |

### 2️⃣ **Reference the SDK in Your Code**

```csharp
using UnderAutomation.Fanuc;
```

### 3️⃣ **Connect to Your Robot**

```csharp
var robot = new FanucRobot();
var parameters = new ConnectionParameters("192.168.0.1");
parameters.Language = Languages.English; // Japanese and Chinese controllers are also supported

parameters.Telnet.Enable = true;
parameters.Telnet.TelnetKclPassword = "your_telnet_password";

parameters.Ftp.Enable = true;
parameters.Ftp.FtpUser = "";
parameters.Ftp.FtpPassword = "";
parameters.Ftp.FtpTimeoutMs = 10000; // optional, default is 30 seconds

parameters.Snpx.Enable = true;

parameters.Rmi.Enable = true;

robot.Connect(parameters);
```

---

## 🔍 Compatibility

✅ **Supported Robots:** R-J3iB, R-30iA, R-30iB, R-50iA
✅ **Operating Systems:** Windows, Linux, macOS  
✅ **.NET Versions:** .NET Framework (≥3.5), .NET Standard, .NET Core, .NET 5/6/8/9

---

## 📢 Contributing

We welcome contributions! Feel free to:

- Report issues via [GitHub Issues](https://github.com/underautomation/Fanuc/issues)
- Submit pull requests with improvements
- Share feedback & feature requests

---

## 📜 License

**⚠️ This SDK requires a commercial license.**  
🔗 Learn more: [UnderAutomation Licensing](https://underautomation.com/fanuc/eula)

---

## 📬 Need Help?

If you have any questions or need support:

- 📖 **Check the Docs**: [Documentation](https://underautomation.com/fanuc/documentation)
- 📩 **Contact Us**: [Support](https://underautomation.com/contact)
