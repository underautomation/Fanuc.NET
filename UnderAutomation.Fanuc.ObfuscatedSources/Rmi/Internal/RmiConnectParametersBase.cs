//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Internal {
	/// <summary>
	/// Base class for RMI connection parameters.
	/// </summary>
	public class RmiConnectParametersBase {

		/// <summary>
		/// Default RMI bootstrap port (16001).
		/// </summary>
		public const int DEFAULT_PORT = 16001;

		/// <summary>
		/// Default read timeout in milliseconds (3000).
		/// </summary>
		public const int DEFAULT_READ_TIMEOUT_MS = 3000;

		/// <summary>
		/// Default write timeout in milliseconds (3000).
		/// </summary>
		public const int DEFAULT_WRITE_TIMEOUT_MS = 3000;


		public RmiConnectParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// RMI bootstrap port number.
		/// </summary>
		public int Port { get; set; }

		/// <summary>
		/// Read timeout in milliseconds.
		/// </summary>
		public int ReadTimeoutMs { get; set; }

		/// <summary>
		/// Write timeout in milliseconds.
		/// </summary>
		public int WriteTimeoutMs { get; set; }
	}
}
