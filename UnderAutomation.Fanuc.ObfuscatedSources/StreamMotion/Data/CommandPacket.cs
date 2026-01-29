//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Command packet to send motion commands to the robot
	/// </summary>
	public class CommandPacket {

		/// <summary>
		/// Default constructor
		/// </summary>
		public CommandPacket()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Constructor with motion data
		/// </summary>
		public CommandPacket(DataStyle dataStyle, MotionData motionData)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Whether this is the last command data packet
		/// </summary>
		public bool IsLastData { get; set; }

		/// <summary>
		/// Type of I/O to read
		/// </summary>
		public IOType ReadIOType { get; set; }

		/// <summary>
		/// Index of I/O to read
		/// </summary>
		public ushort ReadIOIndex { get; set; }

		/// <summary>
		/// Mask for I/O read operation
		/// </summary>
		public ushort ReadIOMask { get; set; }

		/// <summary>
		/// Data style (Cartesian or Joint)
		/// </summary>
		public DataStyle DataStyle { get; set; }

		/// <summary>
		/// Type of I/O to write
		/// </summary>
		public IOType WriteIOType { get; set; }

		/// <summary>
		/// Index of I/O to write
		/// </summary>
		public ushort WriteIOIndex { get; set; }

		/// <summary>
		/// Mask for I/O write operation
		/// </summary>
		public ushort WriteIOMask { get; set; }

		/// <summary>
		/// Value to write to I/O
		/// </summary>
		public ushort WriteIOValue { get; set; }

		/// <summary>
		/// Motion data (position values)
		/// </summary>
		public MotionData MotionData { get; set; }
	}
}
