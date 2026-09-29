//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace StreamMotion.Data {
	/// <summary>
	/// Status sent by the robot every communication cycle
	/// </summary>
	public class StreamMotionStatus {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sequence number of this status. It starts at 1 when the status output starts.
		/// </summary>
		public long SequenceNumber { get; }

		/// <summary>
		/// Time stamp of the robot when the position and the motor currents were read, in ms (resolution 2 ms)
		/// </summary>
		public long Timestamp { get; }

		/// <summary>
		/// Raw status byte
		/// </summary>
		public int RawStatus { get; }

		/// <summary>
		/// The robot executes an IBGN start instruction and waits for positions
		/// </summary>
		public bool IsWaitingForCommand { get; }

		/// <summary>
		/// The robot received at least one position during the current IBGN start instruction
		/// </summary>
		public bool IsCommandReceived { get; }

		/// <summary>
		/// System ready (SYSRDY) is ON
		/// </summary>
		public bool IsSystemReady { get; }

		/// <summary>
		/// The robot is moving
		/// </summary>
		public bool IsMoving { get; }

		/// <summary>
		/// With protocol version 3 or later, the robot sends a status once every n communication cycles when it slows down by itself,
		/// and this value is n. It is 1 in normal operation and with older protocol versions.
		/// </summary>
		public int OutputDivider { get; }

		/// <summary>
		/// Current joint position of the robot (servo position), in degrees (mm for linear axes)
		/// </summary>
		public JointsPosition JointPosition { get; }

		/// <summary>
		/// Current Cartesian position of the robot (servo position) in the world frame, with extended axes.
		/// It is the flange center, or the tool center point when the system variable $STMO.$STAT_US_TCP is TRUE.
		/// </summary>
		public ExtendedCartesianPosition CartesianPosition { get; }

		/// <summary>
		/// Motor current of each axis, in A (9 values)
		/// </summary>
		public double[] MotorCurrents { get; }

		/// <summary>
		/// Type of the I/O read in this status
		/// </summary>
		public IOType ReadIOType { get; }

		/// <summary>
		/// Index of the first I/O read in this status
		/// </summary>
		public int ReadIOIndex { get; }

		/// <summary>
		/// Mask of the I/O read in this status
		/// </summary>
		public int ReadIOMask { get; }

		/// <summary>
		/// State of the 16 I/O read in this status. Bit 0 is the I/O at <xref href="UnderAutomation.Fanuc.StreamMotion.Data.StreamMotionStatus.ReadIOIndex" data-throw-if-not-resolved="false"></xref>.
		/// </summary>
		public int ReadIOValue { get; }
	}
}
