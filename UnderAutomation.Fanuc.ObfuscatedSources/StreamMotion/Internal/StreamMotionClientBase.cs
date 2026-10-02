//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Fanuc.StreamMotion.Data;
using UnderAutomation.Robotics.Motion;
using UnderAutomation.Fanuc.Common;
using System;

namespace UnderAutomation.Fanuc.StreamMotion.Internal {
	/// <summary>
	/// Stream Motion client (J519 option): real-time control of the robot by sending a position every communication cycle.
	/// </summary>
	public abstract class StreamMotionClientBase : IDisposable {

		/// <summary>
		/// Creates a Stream Motion client
		/// </summary>
		protected StreamMotionClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Opens the UDP socket to the robot. The robot does not send anything before <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.StartMonitoring"/> is called.
		/// </summary>
		protected void ConnectInternal(string ip, StreamMotionConnectParametersBase parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disconnects from the robot. If a session is active, the robot is stopped smoothly and the session is finished first.
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Starts the status output of the robot. The robot then sends its status every communication cycle.
		/// The limits of the robot are read first when they are not known yet, and this method returns when the communication cycle is measured.
		/// </summary>
		public void StartMonitoring()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Stops the status output of the robot. Not allowed during a session: call <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.Finish(System.Int32)"/> first.
		/// </summary>
		public void StopMonitoring()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Waits until a program executes an IBGN start instruction and the robot accepts positions.
		/// </summary>
		/// <param name="timeoutMs">Maximum waiting time in milliseconds</param>
		/// <returns>True if the robot accepts positions, false after the timeout</returns>
		public bool WaitForReady(int timeoutMs)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads the velocity, acceleration and jerk limits of all axes from the robot.
		/// The status output is stopped during the reading and started again.
		/// Some controllers do not answer while a program waits on an IBGN start instruction: read the limits before.
		/// Not allowed during a session.
		/// </summary>
		/// <returns>Limits of the robot. They are also stored in <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.Limits"/>, and the reference limits in <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.JointLimits"/>.</returns>
		public StreamMotionLimits ReadLimits()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds a trajectory at the end of the queue. The session starts automatically when the robot accepts positions,
		/// and the trajectories are sent one after the other, without any change between them.
		/// </summary>
		/// <param name="trajectory">Trajectory to send. It must start at <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.QueueEndJointPosition"/> or <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.QueueEndCartesianPosition"/>,
		///             and trajectories created from samples must use the communication cycle of the robot (<see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.CycleTime"/>).
		///             Its I/O events must use signals created by <see cref="UnderAutomation.Fanuc.Motion.FanucMotion.Signal(UnderAutomation.Fanuc.StreamMotion.Data.IOType,System.Int32)"/>.</param>
		/// <returns>Identifier of the motion, to use with <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.WaitForMotion(System.Int32,System.Int32)"/></returns>
		public int Enqueue(Trajectory trajectory)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Waits until the robot received the last position of a queued trajectory
		/// </summary>
		/// <param name="motionId">Identifier returned by <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.Enqueue(UnderAutomation.Robotics.Motion.Trajectory)"/></param>
		/// <param name="timeoutMs">Maximum waiting time in milliseconds</param>
		/// <returns>True when the trajectory was completely sent, false after the timeout or if the trajectory was cancelled</returns>
		public bool WaitForMotion(int motionId, int timeoutMs)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Waits until the queue is empty and the robot does not move. During target tracking, waits until the robot is stopped on the target.
		/// </summary>
		/// <param name="timeoutMs">Maximum waiting time in milliseconds</param>
		/// <returns>True when idle, false after the timeout</returns>
		public bool WaitForIdle(int timeoutMs)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Finishes the session when the queue is empty and the robot is at rest: the last position is sent with the end flag,
		/// and the program continues after the IBGN end instruction. If a program waits on IBGN start without session, it is released at the current position.
		/// The callback streaming and the target tracking are stopped first.
		/// </summary>
		/// <param name="timeoutMs">Maximum waiting time in milliseconds</param>
		/// <returns>True when the session is finished, false after the timeout or if the session ended for another reason</returns>
		public bool Finish(int timeoutMs)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Stops smoothly on the path of the current trajectory. The queue is kept and <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.Resume"/> continues the motion.
		/// Use it instead of a HOLD, which is not available during Stream Motion.
		/// </summary>
		public void Pause()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Continues the queued trajectories after <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.Pause"/>
		/// </summary>
		public void Resume()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Stops smoothly on the path of the current trajectory, then cancels the current and the queued trajectories.
		/// The session stays open and the robot keeps its position. The callback streaming and the target tracking are stopped,
		/// and the robot stops as fast as the limits allow.
		/// </summary>
		public void Abort()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Starts to take the positions from the <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.SetpointRequested"/> event instead of the queue.
		/// The session starts automatically when the robot accepts positions.
		/// </summary>
		/// <param name="format">Format of the positions given by the event</param>
		public void StartCallbackStreaming(PositionFormat format)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Stops the callback streaming. The last position is kept, and the robot stops smoothly if it was moving.
		/// </summary>
		public void StopCallbackStreaming()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Starts to follow a target position: the robot goes to the last target given by <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.SetJointTrackingTarget(UnderAutomation.Fanuc.Common.JointsPosition)"/> or
		/// <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.SetCartesianTrackingTarget(UnderAutomation.Fanuc.Common.XYZWPRPosition)"/> as fast as the limits allow, and stops on it. The target can change at any time,
		/// even during the motion: the robot then goes smoothly to the new target.
		/// The limits are <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.JointLimits"/> in joint format, and <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.CartesianLimits"/> in Cartesian format (the linear and angular limits
		/// are shared between X, Y, Z and between the 3 rotation axes). Each axis moves independently, so the path to the target is not a straight line.
		/// The first target is the current position. The session starts automatically when the robot accepts positions.
		/// The delay between a new target and the start of the motion is about <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.BufferLead"/> cycles plus the delay of the robot:
		/// reduce the buffer lead time of the connection parameters for a faster reaction.
		/// </summary>
		/// <param name="format">Format of the targets</param>
		/// <param name="speedPercent">Velocity in percent of the limits (greater than 0, up to 100)</param>
		/// <param name="accelerationPercent">Acceleration and jerk in percent of the limits (greater than 0, up to 100)</param>
		public void StartTracking(PositionFormat format, double speedPercent = 100, double accelerationPercent = 100)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gives a new joint target to follow (see <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.StartTracking(UnderAutomation.Robotics.Motion.PositionFormat,System.Double,System.Double)"/>)
		/// </summary>
		/// <param name="target">Target joint position</param>
		public void SetJointTrackingTarget(JointsPosition target)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gives a new Cartesian target to follow (see <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.StartTracking(UnderAutomation.Robotics.Motion.PositionFormat,System.Double,System.Double)"/>).
		/// Extended axes are used when the target is an <see cref="UnderAutomation.Fanuc.Common.ExtendedCartesianPosition"/>, otherwise they keep their target.
		/// </summary>
		/// <param name="target">Target position, in the frame of the Cartesian positions sent to the robot</param>
		public void SetCartesianTrackingTarget(XYZWPRPosition target)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Stops the target tracking. If the robot was moving, it stops as fast as the limits allow, then it keeps its position.
		/// </summary>
		public void StopTracking()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Adds a range of 16 consecutive I/O to read. Each position sent to the robot reads one range, so several ranges are read one after the other.
		/// Values are only read during a session.
		/// </summary>
		/// <param name="type">I/O type</param>
		/// <param name="index">Index of the first I/O of the range (starts at 1)</param>
		public void AddIOMonitor(IOType type, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Removes all ranges of I/O to read
		/// </summary>
		public void ClearIOMonitors()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns the last read state of one I/O. The I/O must be in a range added with <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.AddIOMonitor(UnderAutomation.Fanuc.StreamMotion.Data.IOType,System.Int32)"/>.
		/// It returns false while the range was never read.
		/// </summary>
		/// <param name="type">I/O type</param>
		/// <param name="index">I/O index</param>
		public bool GetIO(IOType type, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes one digital I/O with the next position sent to the robot (only during a session)
		/// </summary>
		/// <param name="type">I/O type</param>
		/// <param name="index">I/O index (starts at 1)</param>
		/// <param name="value">Value to write</param>
		public void WriteIO(IOType type, int index, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Writes up to 16 consecutive digital I/O with the next position sent to the robot (only during a session)
		/// </summary>
		/// <param name="type">I/O type</param>
		/// <param name="index">Index of the first I/O (starts at 1)</param>
		/// <param name="mask">Bits of the I/O to write. Bit 0 is the I/O at index.</param>
		/// <param name="value">Values of the I/O. Bit 0 is the I/O at index.</param>
		public void WriteIOGroup(IOType type, int index, int mask, int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disconnects and releases the resources
		/// </summary>
		public void Dispose()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disconnects and releases the resources
		/// </summary>
		protected virtual void Dispose(bool disposing)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// IP address of the robot
		/// </summary>
		public string Ip { get; }

		/// <summary>
		/// UDP port of the robot
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// Protocol version used by this client
		/// </summary>
		public int ProtocolVersion { get; }

		/// <summary>
		/// Indicates whether the client is connected
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Current state of the client
		/// </summary>
		public StreamMotionState State { get; }

		/// <summary>
		/// Last status received from the robot, or null if no status was received
		/// </summary>
		public StreamMotionStatus LastStatus { get; }

		/// <summary>
		/// Communication cycle of the robot measured from the status, in seconds (for example 0.008 or 0.002). 0 while it is not known.
		/// Trajectories are sampled at this period.
		/// </summary>
		public double CycleTime { get; }

		/// <summary>
		/// Number of positions sent in advance and kept in the robot buffer during the current session
		/// </summary>
		public int BufferLead { get; }

		/// <summary>
		/// Number of sessions started since the connection. A session starts when positions are sent after an IBGN start instruction.
		/// </summary>
		public int SessionCount { get; }

		/// <summary>
		/// Communication statistics since the status output was started
		/// </summary>
		public StreamMotionStatistics Statistics { get; }

		/// <summary>
		/// Limits read from the robot by <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.ReadLimits"/> or when the status output starts. Null if they were not read.
		/// </summary>
		public StreamMotionLimits Limits { get; }

		/// <summary>
		/// Joint limits used to stop the robot smoothly when the positions stop in joint format.
		/// It is set to the reference limits of the robot when the limits are read.
		/// </summary>
		public JointLimits JointLimits { get; set; }

		/// <summary>
		/// Cartesian limits used to stop the robot smoothly when the positions stop in Cartesian format.
		/// When it is null, conservative values are used.
		/// </summary>
		public CartesianLimits CartesianLimits { get; set; }

		/// <summary>
		/// Maximum distance between the first position of a trajectory and the position where it starts, in mm or degrees (default 0.01).
		/// </summary>
		public double StartTolerance { get; set; }

		/// <summary>
		/// Time in seconds by which the I/O events of trajectories are sent before their position (default 0).
		/// It compensates the delay between the reception of a position by the robot and the real motion.
		/// </summary>
		public double IOAnticipation { get; set; }

		/// <summary>
		/// Position where the next queued joint trajectory must start: end of the queue, or current position when the queue is empty.
		/// Null if no status was received.
		/// </summary>
		public JointsPosition QueueEndJointPosition { get; }

		/// <summary>
		/// Position where the next queued Cartesian trajectory must start: end of the queue, or last position sent when the queue is empty.
		/// Before any Cartesian position was sent, it is the Cartesian position of the status (flange center in the world frame by default).
		/// Some controllers expect Cartesian positions of the active tool frame: the start of the first trajectory is then not checked.
		/// Null if no status was received.
		/// </summary>
		public ExtendedCartesianPosition QueueEndCartesianPosition { get; }

		/// <summary>
		/// Number of trajectories waiting or running
		/// </summary>
		public int QueuedMotionCount { get; }

		/// <summary>
		/// Indicates if positions are given by the <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.SetpointRequested"/> event
		/// </summary>
		public bool IsCallbackStreaming { get; }

		/// <summary>
		/// Indicates if the robot follows a target given by <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.SetJointTrackingTarget(UnderAutomation.Fanuc.Common.JointsPosition)"/> or <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.SetCartesianTrackingTarget(UnderAutomation.Fanuc.Common.XYZWPRPosition)"/>
		/// </summary>
		public bool IsTracking { get; }

		/// <summary>
		/// Indicates if the format of the positions is fixed. A session uses only one format, chosen by the first queued trajectory,
		/// <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.StartTracking(UnderAutomation.Robotics.Motion.PositionFormat,System.Double,System.Double)"/> or <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.StartCallbackStreaming(UnderAutomation.Robotics.Motion.PositionFormat)"/>. While this is true, positions in the other format
		/// throw a <see cref="UnderAutomation.Fanuc.StreamMotion.StreamMotionException"/> with <see cref="UnderAutomation.Fanuc.StreamMotion.StreamMotionError.FormatMismatch"/>.
		/// It becomes false when the queue is empty and no session is active: call <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.Finish(System.Int32)"/> to use the other format in the next session.
		/// </summary>
		public bool HasActiveFormat { get; }

		/// <summary>
		/// Format of the positions of the current session or of the queued trajectories. Only valid when <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.HasActiveFormat"/> is true.
		/// </summary>
		public PositionFormat ActiveFormat { get; }

		/// <summary>
		/// Speed of the queued trajectories in percent (greater than 0, up to 100, default 100). The robot itself must run at 100% override,
		/// so this value slows down the trajectories on their path: the positions are the same, only the time is stretched.
		/// A change is applied progressively.
		/// </summary>
		public double Override { get; set; }

		/// <summary>
		/// Indicates if the queued trajectories are paused
		/// </summary>
		public bool IsPaused { get; }

		/// <summary>
		/// Last values of the ranges of I/O added with <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.AddIOMonitor(UnderAutomation.Fanuc.StreamMotion.Data.IOType,System.Int32)"/>
		/// </summary>
		public IOValue[] IOValues { get; }

		/// <summary>
		/// Raised when a status is received. It is raised on a dedicated thread and only with the latest status:
		/// if the handler is slow, some status are skipped.
		/// </summary>
		public event EventHandler<StatusReceivedEventArgs> StatusReceived;

		/// <summary>
		/// Raised when a session starts (first position sent after an IBGN start instruction)
		/// </summary>
		public event EventHandler<SessionEventArgs> SessionStarted;

		/// <summary>
		/// Raised when a session ends
		/// </summary>
		public event EventHandler<SessionEndedEventArgs> SessionEnded;

		/// <summary>
		/// Raised when the robot received the last position of a queued trajectory
		/// </summary>
		public event EventHandler<MotionEventArgs> MotionCompleted;

		/// <summary>
		/// Raised when the queue becomes empty while the robot is moving. The robot is then stopped smoothly.
		/// </summary>
		public event EventHandler<MotionEventArgs> Underrun;

		/// <summary>
		/// Raised when an error occurs in the communication thread
		/// </summary>
		public event EventHandler<StreamMotionErrorEventArgs> ErrorOccurred;

		/// <summary>
		/// Raised in callback streaming mode (see <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionClientBase.StartCallbackStreaming(UnderAutomation.Robotics.Motion.PositionFormat)"/>) each time a position must be sent.
		/// The handler must give the next position with SetJoints or SetCartesian.
		/// It runs on the communication thread, a few cycles before the robot executes the position, and must return quickly.
		/// The first requested position (CycleIndex 0) must be the current position of the robot, and the next ones must connect smoothly to it.
		/// </summary>
		public event EventHandler<SetpointRequestEventArgs> SetpointRequested;
	}
}
