## Stream Motion (J519): new API

> **Breaking change:** the Stream Motion API was rewritten. You do not build and send packets anymore. The SDK synchronizes the positions with the status of the robot, sends a few positions in advance, and stops the robot smoothly when your application stops giving positions. Code written for the previous API must be updated (see "How to migrate" below).

The client (`robot.StreamMotion`, or `StreamMotionClient` alone) gives three ways to move the robot:

- **Queue of trajectories:** plan a trajectory with the new motion planner and call `Enqueue()`. It returns an id for `WaitForMotion()`. `WaitForIdle()` waits for the whole queue. Control the motion with `Override`, `Pause()`, `Resume()` and `Abort()`.
- **Target tracking:** call `StartTracking()`, then change the target at any time with `SetJointTrackingTarget()` or `SetCartesianTrackingTarget()`.
- **Callback streaming:** call `StartCallbackStreaming()`, then give each position in the `SetpointRequested` event with `e.SetJoints()`, `e.SetCartesian()` or `e.Hold()`.

```csharp
using UnderAutomation.Fanuc.Motion;     // FanucMotion
using UnderAutomation.Robotics.Motion;  // MotionPlanner, Trajectory

var parameters = new ConnectionParameters("192.168.0.1");
parameters.StreamMotion.Enable = true;
robot.Connect(parameters);
var sm = robot.StreamMotion;

// Read the limits of the robot, start the status output and measure the communication cycle
sm.StartMonitoring();

// J1 +10 degrees then back, at 20% of the velocity limits
JointsPosition start = sm.QueueEndJointPosition;
var target = new JointsPosition(start.Values) { J1 = start.J1 + 10 };
var planner = new MotionPlanner(sm.JointLimits, null);
Trajectory trajectory = planner.CreateJointPath(FanucMotion.ToJointValues(start))
    .MoveJoint(FanucMotion.ToJointValues(target), 20, FanucMotion.Cnt(100))
    .MoveJoint(FanucMotion.ToJointValues(start), 20, FanucMotion.Fine())
    .Build();

// The motion starts when the TP program reaches IBGN start
sm.WaitForMotion(sm.Enqueue(trajectory), 60000);

// Release the TP program: it continues after IBGN end
sm.Finish(10000);
```

```csharp
// Follow a target that can change at any time, at 30% of the velocity limits
sm.StartTracking(PositionFormat.Joint, 30);
sm.SetJointTrackingTarget(new JointsPosition(start.Values) { J1 = start.J1 + 10 });
sm.WaitForIdle(10000);
sm.StopTracking();
```

Other new features:

- Protocol versions 1, 2 and 3 with `ConnectionParameters.StreamMotion.ProtocolVersion` (default 1, must not be higher than `$STMO.$USABLE_VER`). Version 2 sends joint positions in double precision.
- New connection settings: `BufferLeadTime` (0.024 s), `PacketStackSize` (10), `StatusTimeoutMs` (1000 ms) and `HighPriority` (true). `Port` is still 60015.
- `State` gives the state of the client: `Disconnected`, `Connected`, `Monitoring`, `Ready`, `Streaming` or `Finishing`. `WaitForReady()` waits until the TP program reaches `IBGN start`.
- `LastStatus` and the `StatusReceived` event give the joint and Cartesian positions, the motor currents and the flags of the robot (`IsWaitingForCommand`, `IsMoving`...). `CycleTime` gives the measured communication cycle and `Statistics` the quality of the communication.
- New events: `SessionStarted`, `SessionEnded` (with a `SessionEndReason`), `MotionCompleted`, `Underrun` and `ErrorOccurred`. Errors are thrown as `StreamMotionException`, with a `StreamMotionError` code.
- A session uses only one format, joint or Cartesian: call `Finish()` to use the other format in the next session. `HasActiveFormat` and `ActiveFormat` give the current format.
- `ReadLimits()` reads the velocity, acceleration and jerk limits of each axis. `ReferenceLimits` are always safe, `ComputeLimits()` gives the limits for a flange speed and a payload, and `GetTable()` gives the raw table of one axis.
- I/O synchronized with the motion: `AddIOMonitor()` reads ranges of 16 I/O, `GetIO()` and `IOValues` give their values, `WriteIO()` and `WriteIOGroup()` write outputs, and `IOAnticipation` compensates the delay of the robot. An output can also be switched at a precise time of a trajectory.
- `Features.HasStreamMotion` tells if the J519 option is installed on the robot.

**How to migrate:**

| Previous API                                                              | New API                                                                                                                   |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| `Start()` / `Stop()`                                                      | `StartMonitoring()` / `StopMonitoring()`                                                                                  |
| `SendJointCommand()`, `SendCartesianCommand()`, `SendCommand()` in a loop | `Enqueue()` a `Trajectory`, follow a target with `StartTracking()`, or give each position with `StartCallbackStreaming()` |
| `isLastData = true`                                                       | `Finish()`                                                                                                                |
| `StateReceived` event, `LastState`                                        | `StatusReceived` event, `LastStatus`                                                                                      |
| `ReceiveError` event                                                      | `ErrorOccurred` event                                                                                                     |
| `RequestThreshold()`                                                      | `ReadLimits()`                                                                                                            |
| `IsStreaming`                                                             | `State == StreamMotionState.Streaming`                                                                                    |
| `RobotFrequency`, `MeasuredFrequency`                                     | `CycleTime`                                                                                                               |
| `PacketCount`                                                             | `Statistics`                                                                                                              |
| `SendTimeoutMs`, `ReceiveTimeoutMs`                                       | `StatusTimeoutMs`                                                                                                         |
| `StreamMotionClient.Connect(ip, port, sendTimeoutMs, receiveTimeoutMs)`   | `StreamMotionClient.Connect(ip, new StreamMotionConnectParameters { ... })`                                               |

The types `CommandPacket`, `StatePacket`, `MotionData`, `DataStyle`, `RobotStatus`, `AckPacket`, `ThresholdType`, `IOReadResult`, `StateReceivedEventArgs` and `ReceiveErrorEventArgs` were removed.

Documentation: [Stream Motion](https://underautomation.com/fanuc/documentation/stream-motion)

## New motion planner

The new namespace `UnderAutomation.Robotics.Motion` creates smooth trajectories that respect velocity, acceleration and jerk limits. It works offline, without robot. Trajectories can be sent with Stream Motion, used in a simulation, or checked before use.

The `UnderAutomation.Robotics` namespaces are common to all UnderAutomation robot SDKs: the same code plans trajectories for other robot brands. The FANUC specific part is in `UnderAutomation.Fanuc.Motion`: the `FanucMotion` class converts `JointsPosition` and `XYZWPRPosition`, gives the FINE, CNT and CR terminations and the I/O signals, and returns the FANUC positions of a trajectory.

- `JointLimits` (velocity, acceleration and jerk of 9 axes) and `CartesianLimits` (linear and angular velocity, acceleration and jerk). On a robot, read the joint limits with `robot.StreamMotion.ReadLimits().ReferenceLimits`.
- `MotionPlanner` creates joint and Cartesian paths. With `ToolFrame` and `UserFrame`, targets are tool positions in this user frame.
- Positions of the planner: `JointValues` and `CartesianPose` (X, Y, Z, `Orientation` and external axes). `Orientation` converts from and to quaternions, Euler angles (`EulerConvention`), rotation vectors and rotation matrices. The W, P, R angles of FANUC are `EulerConvention.FixedXYZ`.
- Joint paths: `MoveJoint()` (speed in %, termination, optional acceleration in %), `MoveJointTime()`, `MoveJointSpline()`, `Wait()` and `SetIO()`.
- Cartesian paths: `MoveLinear()`, `MoveCircular()`, `MoveLinearTime()`, `MoveSpline()`, and shapes in any plane: `AddCircle()`, `AddRectangle()`, `AddPolygon()`, `AddHelix()` and `AddSpiral()`.
- Terminations as in a TP program: `FanucMotion.Fine()`, `FanucMotion.Cnt(0..100)` and `FanucMotion.Cr(distanceMm)`. They are the same as `Termination.Stop()`, `Termination.Overlap(percent)` and `Termination.Corner(distanceMm)`.
- All motions use jerk limited profiles. The profile is also available alone with `DoubleSProfile`.

```csharp
using UnderAutomation.Fanuc.Motion;            // FanucMotion
using UnderAutomation.Fanuc.StreamMotion.Data; // IOType
using UnderAutomation.Robotics.Geometry;       // JointValues, CartesianPose
using UnderAutomation.Robotics.Motion;         // MotionPlanner, Trajectory

var jointLimits = new JointLimits(
    new double[] { 120, 120, 180, 180, 180, 180 },         // velocity, deg/s
    new double[] { 300, 300, 450, 675, 675, 675 },         // acceleration, deg/s2
    new double[] { 1125, 1125, 1687, 2530, 1265, 2530 });  // jerk, deg/s3
var cartesianLimits = new CartesianLimits(500, 2000, 10000, 90, 360, 1800);
var planner = new MotionPlanner(jointLimits, cartesianLimits);

// J P[1] 100% CNT50, J P[2] 30% FINE ACC50, DO[1]=ON, WAIT 0.5 s, then back in 2 s
var start = new JointValues(0, 0, 0, 0, -90, 0);
Trajectory joint = planner.CreateJointPath(start)
    .MoveJoint(new JointValues(40, 0, 0, 0, -90, 0), 100, FanucMotion.Cnt(50))
    .MoveJoint(new JointValues(40, 30, -20, 0, -60, 0), 30, FanucMotion.Fine(), 50)
    .SetIO(FanucMotion.Signal(IOType.DO, 1), true)
    .Wait(0.5)
    .MoveJointTime(start, 2.0, FanucMotion.Fine())
    .Build();

// L 200mm/sec CR10, then C at 150mm/sec FINE
Func<double, double, double, double, double, double, CartesianPose> wpr =
    (x, y, z, w, p, r) => FanucMotion.ToCartesianPose(new XYZWPRPosition(x, y, z, w, p, r));
Trajectory cartesian = planner.CreateCartesianPath(wpr(500, 0, 300, 180, 0, 0))
    .MoveLinear(wpr(600, 0, 300, 180, 0, 0), 200, FanucMotion.Cr(10))
    .MoveCircular(wpr(550, 150, 300, 180, 0, 0), wpr(500, 100, 300, 180, 0, 30), 150, FanucMotion.Fine())
    .Build();

// FANUC positions of the trajectory, one per 8 ms, with continuous W, P, R
ExtendedCartesianPosition[] positions = FanucMotion.SampleCartesian(cartesian, 0.008);
```

A `Trajectory` gives its `Duration`, the position at any time (`GetJoints()`, `GetCartesian()`), samples at a fixed period (`SampleJoints()`, `SampleCartesian()`) and its I/O events (`IOEvents`, `AddIOEvent()`). Trajectories can also be created from your own positions:

- `Trajectory.FromJointSamples()` and `FanucMotion.FromCartesianSamples()`: one position per communication cycle, sent without any change.
- `Trajectory.FromTimedJoints()` and `Trajectory.FromTimedCartesian()`: a few positions with their time.
- `Check()` and `CheckCartesian()` compute the velocity, acceleration and jerk as the robot does and return a report. `Retime()` and `RetimeCartesian()` play the same path slower so that the limits are respected (with `singlePrecision`, also after the rounding of protocol version 1).

```csharp
Trajectory trajectory = Trajectory.FromTimedJoints(
    new[] { new JointValues(0, 0, 0, 0, -90, 0), new JointValues(90, 0, 0, 0, -90, 0) },
    new[] { 0.0, 0.5 });

TrajectoryReport report = trajectory.Check(jointLimits, 0.008, true);
if (!report.IsValid)
    trajectory = trajectory.Retime(jointLimits, 0.008, true);

JointValues[] samples = trajectory.SampleJoints(0.008);
```

Documentation: [Motion planner](https://underautomation.com/fanuc/documentation/motion)

## Quaternions and frame operations

New `Quaternion` class (`Qw`, `Qx`, `Qy`, `Qz`) with `Slerp()`, `AngleTo()`, `FromAxisAngle()`, `ToAxisAngle()`, `FromRotationMatrix()`, `ToRotationMatrix()`, `Multiply()`, `Conjugate()` and `Normalize()`.

New methods on `XYZWPRPosition`, so also on `CartesianPosition`: `GetQuaternion()`, `SetQuaternion()`, `Multiply()`, `Inverse()`, `FlangeToTcp()`, `TcpToFlange()`, `UserFrameToWorld()` and `WorldToUserFrame()`.

`ToHomogeneousMatrix()` moved from `CartesianPosition` to its base class `XYZWPRPosition`. Existing code still compiles.

```csharp
var tool = new XYZWPRPosition(0, 0, 150, 0, 0, 0);            // tool frame, relative to the flange
var userFrame = new XYZWPRPosition(800, -200, 0, 0, 0, 90);    // user frame, relative to the world frame
var flange = new XYZWPRPosition(700, 0, 400, 180, 0, 0);       // flange in the world frame

XYZWPRPosition tcpInUserFrame = flange.FlangeToTcp(tool).WorldToUserFrame(userFrame);

Quaternion a = new XYZWPRPosition(0, 0, 0, 180, 0, 0).GetQuaternion();
Quaternion b = new XYZWPRPosition(0, 0, 0, 180, 30, 0).GetQuaternion();
Quaternion halfWay = Quaternion.Slerp(a, b, 0.5);
double angle = a.AngleTo(b); // 30 degrees
```

Documentation: [Frames & orientations](https://underautomation.com/fanuc/documentation/motion-frames-orientations)
