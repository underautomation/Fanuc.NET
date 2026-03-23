//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Cgtp.Internal;

namespace Common {
	/// <summary>
	/// CGTP Web Server connection parameters
	/// </summary>
	public class CgtpConnectParameters : CgtpConnectParametersBase {


		public CgtpConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Should enable CGTP Web Server for this connection (default: true)
		/// </summary>
		public bool Enable { get; set; }
	}
}
