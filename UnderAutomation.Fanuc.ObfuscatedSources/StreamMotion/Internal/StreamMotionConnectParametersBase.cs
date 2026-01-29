//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Internal {
	/// <summary>
	/// Base connection parameters for Stream Motion (J519)
	/// </summary>
	public class StreamMotionConnectParametersBase {

		/// <summary>
		/// Default UDP port for Stream Motion (J519)
		/// </summary>
		public const int DEFAULT_PORT = 60015;

		/// <summary>
		/// Default send timeout in milliseconds
		/// </summary>
		public const int DEFAULT_SEND_TIMEOUT_MS = 1000;

		/// <summary>
		/// Default receive timeout in milliseconds
		/// </summary>
		public const int DEFAULT_RECEIVE_TIMEOUT_MS = 1000;


		public StreamMotionConnectParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// UDP port for Stream Motion communication
		/// </summary>
		public int Port { get; set; }

		/// <summary>
		/// Send timeout in milliseconds
		/// </summary>
		public int SendTimeoutMs { get; set; }

		/// <summary>
		/// Receive timeout in milliseconds
		/// </summary>
		public int ReceiveTimeoutMs { get; set; }
	}
}
