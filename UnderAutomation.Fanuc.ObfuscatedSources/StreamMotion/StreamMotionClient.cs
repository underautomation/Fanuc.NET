//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using StreamMotion.Internal;

namespace StreamMotion {
	/// <summary>
	/// Stream Motion client for standalone use (J519 option)
	/// Provides UDP-based real-time streaming motion control for Fanuc robots
	/// </summary>
	public class StreamMotionClient : StreamMotionClientBase, IDisposable {

		/// <summary>
		/// Creates a new instance of the Stream Motion client
		/// </summary>
		public StreamMotionClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to the robot using Stream Motion protocol
		/// </summary>
		/// <param name="ip">IP address of the robot</param>
		/// <param name="port">UDP port (default: 60015)</param>
		/// <param name="sendTimeoutMs">Send timeout in milliseconds</param>
		/// <param name="receiveTimeoutMs">Receive timeout in milliseconds</param>
		public void Connect(string ip, int port = 60015, int sendTimeoutMs = 1000, int receiveTimeoutMs = 1000)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
