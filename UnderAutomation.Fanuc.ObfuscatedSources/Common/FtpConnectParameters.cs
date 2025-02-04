//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Common {
	/// <summary>
	/// Memory access parameters
	/// </summary>
	public class FtpConnectParameters : FtpConnectParametersBase {

		/// <summary>
		/// Should enable memory access for this connection
		/// </summary>
		public bool Enable { get; set; }
	}
}
