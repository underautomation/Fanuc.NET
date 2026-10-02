//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.StreamMotion.Internal {
	/// <summary>
	/// Connection parameters for Stream Motion (J519 option)
	/// </summary>
	public class StreamMotionConnectParametersBase {

		/// <summary>
		/// Default UDP port of the robot for Stream Motion
		/// </summary>
		public const int DEFAULT_PORT = 60015;

		/// <summary>
		/// Default protocol version. Version 1 is accepted by all controllers.
		/// </summary>
		public const int DEFAULT_PROTOCOL_VERSION = 1;

		/// <summary>
		/// Default time of positions kept in advance in the robot buffer, in seconds
		/// </summary>
		public const double DEFAULT_BUFFER_LEAD_TIME = 0.024;

		/// <summary>
		/// Default size of the robot buffer (default value of the system variable $STMO.$PKT_STACK)
		/// </summary>
		public const int DEFAULT_PACKET_STACK_SIZE = 10;

		/// <summary>
		/// Default maximum time without status from the robot, in milliseconds
		/// </summary>
		public const int DEFAULT_STATUS_TIMEOUT_MS = 1000;


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


		public StreamMotionConnectParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// UDP port of the robot for Stream Motion
		/// </summary>
		public int Port { get; set; }

		/// <summary>
		/// Protocol version, from 1 to 3. The highest version accepted by a controller is in the system variable $STMO.$USABLE_VER.
		/// A higher version raises an alarm on the robot and no status is received.
		/// Version 2 sends joint positions in double precision. Version 3 lets the robot send its status less often when it slows down by itself.
		/// A version 4 exists on some recent controllers for ROS 2 only. It is not supported.
		/// </summary>
		public int ProtocolVersion { get; set; }

		/// <summary>
		/// Time of positions sent in advance and kept in the robot buffer, in seconds.
		/// It protects against late packets from the PC, but adds the same delay to the motion.
		/// It is converted to a number of communication cycles, limited by <see cref="UnderAutomation.Fanuc.StreamMotion.Internal.StreamMotionConnectParametersBase.PacketStackSize"/> minus 2. 0 disables the advance.
		/// </summary>
		public double BufferLeadTime { get; set; }

		/// <summary>
		/// Size of the robot buffer. It must be equal to the system variable $STMO.$PKT_STACK of the robot (2 to 10).
		/// </summary>
		public int PacketStackSize { get; set; }

		/// <summary>
		/// Maximum time without status from the robot before the connection is considered lost, in milliseconds
		/// </summary>
		public int StatusTimeoutMs { get; set; }

		/// <summary>
		/// Runs the communication thread with a high priority to reduce delays (default: true)
		/// </summary>
		public bool HighPriority { get; set; }
	}
}
