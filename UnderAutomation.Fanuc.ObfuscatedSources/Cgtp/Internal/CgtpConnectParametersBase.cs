//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Cgtp.Internal {
	/// <summary>
	/// Base class for CGTP Web Server connection parameters.
	/// </summary>
	public class CgtpConnectParametersBase {

		/// <summary>
		/// Default HTTP port for CGTP Web Server.
		/// </summary>
		public const int DEFAULT_PORT = 3080;

		/// <summary>
		/// Default request timeout in milliseconds.
		/// </summary>
		public const int DEFAULT_REQUEST_TIMEOUT_MS = 3000;


		public CgtpConnectParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// HTTP port number of the CGTP Web Server.
		/// </summary>
		public int Port { get; set; }

		/// <summary>
		/// HTTP request timeout in milliseconds.
		/// </summary>
		public int RequestTimeoutMs { get; set; }
	}
}
