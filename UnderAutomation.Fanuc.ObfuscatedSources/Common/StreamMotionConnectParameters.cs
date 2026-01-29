//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using StreamMotion.Internal;

namespace Common {
	/// <summary>
	/// Stream Motion connection parameters (J519 option)
	/// </summary>
	public class StreamMotionConnectParameters : StreamMotionConnectParametersBase {


		public StreamMotionConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Should enable Stream Motion for this connection (default: false)
		/// </summary>
		public bool Enable { get; set; }

		/// <summary>
		/// IP address of the robot for standalone Stream Motion connections
		/// </summary>
		public string Ip { get; set; }
	}
}
