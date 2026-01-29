//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// State packet received from the robot containing current position, status, and motor currents
	/// </summary>
	public class StatePacket : EventArgs {

		/// <summary>
		/// Returns a string representation
		/// </summary>
		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public StatePacket()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Time when this packet was received on the PC (UTC ticks)
		/// </summary>
		public long ReceivedAtTicks { get; }

		/// <summary>
		/// Time when this packet was received on the PC
		/// </summary>
		public DateTime ReceivedAt { get; }

		/// <summary>
		/// Packet type (always State=0)
		/// </summary>
		public PacketTypeFromRobot PacketType { get; }

		/// <summary>
		/// Protocol version number
		/// </summary>
		public uint VersionNumber { get; }

		/// <summary>
		/// Sequence number for packet tracking
		/// </summary>
		public uint SequenceNumber { get; }

		/// <summary>
		/// Robot status flags
		/// </summary>
		public RobotStatus Status { get; }

		/// <summary>
		/// Result of I/O read operation
		/// </summary>
		public IOReadResult IORead { get; }

		/// <summary>
		/// Time stamp when position data and motor current are recorded (ms, resolution 2ms)
		/// </summary>
		public uint TimeStamp { get; }

		/// <summary>
		/// Current Cartesian position (world to tool0)
		/// </summary>
		public MotionData CartesianPosition { get; }

		/// <summary>
		/// Current joint position
		/// </summary>
		public MotionData JointPosition { get; }

		/// <summary>
		/// Current motor currents (Amperes)
		/// </summary>
		public MotionData MotorCurrents { get; }
	}
}
