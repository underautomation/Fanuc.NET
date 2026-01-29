//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using StreamMotion.Data;
using System;

namespace StreamMotion.Internal {
	/// <summary>
	/// Base class for Stream Motion client (J519 option)
	/// Provides UDP-based real-time streaming motion control.
	/// The robot sends state packets continuously at high frequency (~500Hz).
	/// Commands should be sent in response to StateReceived events using the sequence number from the received state.
	/// </summary>
	public abstract class StreamMotionClientBase : IDisposable {

		/// <summary>
		/// Creates a new instance of the Stream Motion client
		/// </summary>
		public StreamMotionClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to the robot
		/// </summary>
		protected void ConnectInternal(string ip, int port, int sendTimeoutMs, int receiveTimeoutMs)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disconnect from the robot
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Start streaming motion. This starts a background thread that continuously receives state packets
		/// and raises the StateReceived event for each packet.
		/// </summary>
		public void Start()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Stop streaming motion
		/// </summary>
		public void Stop()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Queue a motion command to be sent with the next state packet's sequence number.
		/// The command will be sent automatically when the next state packet is received.
		/// It is recommended to call this method within the StateReceived event handler.
		/// </summary>
		/// <param name="command">Command packet to send</param>
		public void SendCommand(CommandPacket command)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Queue a joint motion command
		/// </summary>
		public void SendJointCommand(MotionData jointPositions, bool isLastData = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Queue a joint motion command with I/O read
		/// </summary>
		public void SendJointCommand(MotionData jointPositions, IOType readIOType, ushort readIOIndex, ushort readIOMask, bool isLastData = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Queue a Cartesian motion command
		/// </summary>
		public void SendCartesianCommand(MotionData cartesianPosition, bool isLastData = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Request threshold data for an axis.
		/// Note: This is a synchronous blocking call that should not be called during active streaming.
		/// </summary>
		/// <param name="axisNumber">Axis number (1-9)</param>
		/// <param name="thresholdType">Type of threshold to request</param>
		/// <returns>Acknowledgment packet with threshold data</returns>
		public AckPacket RequestThreshold(uint axisNumber, ThresholdType thresholdType)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Dispose the client
		/// </summary>
		public void Dispose()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Dispose the client
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
		/// UDP port used for communication
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// Indicates whether the client is connected
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Indicates whether the client is connected (alias for Connected)
		/// </summary>
		public bool IsConnected { get; }

		/// <summary>
		/// Indicates whether streaming is currently active
		/// </summary>
		public bool IsStreaming { get; }

		/// <summary>
		/// Last received state packet
		/// </summary>
		public StatePacket LastState { get; }

		/// <summary>
		/// Send timeout in milliseconds
		/// </summary>
		public int SendTimeoutMs { get; }

		/// <summary>
		/// Receive timeout in milliseconds
		/// </summary>
		public int ReceiveTimeoutMs { get; }

		/// <summary>
		/// Frequency based on robot timestamp (Hz). Calculated from consecutive packet timestamps.
		/// </summary>
		public double RobotFrequency { get; }

		/// <summary>
		/// Measured frequency based on PC receive time (Hz). Actual rate at which packets arrive.
		/// </summary>
		public double MeasuredFrequency { get; }

		/// <summary>
		/// Total number of state packets received since streaming started
		/// </summary>
		public long PacketCount { get; }

		/// <summary>
		/// Event raised when a state packet is received from the robot.
		/// This event is raised on a background thread at high frequency (~500Hz).
		/// It is recommended to call SendCommand() within this handler to maintain proper timing.
		/// </summary>
		public event EventHandler<StateReceivedEventArgs> StateReceived;

		/// <summary>
		/// Event raised when an error occurs during packet receiving
		/// </summary>
		public event EventHandler<ReceiveErrorEventArgs> ReceiveError;
	}
}
