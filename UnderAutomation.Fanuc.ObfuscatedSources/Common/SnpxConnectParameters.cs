//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Snpx.Internal;

namespace Common {
	/// <summary>
	/// Memory access parameters
	/// </summary>
	public class SnpxConnectParameters : SnpxConnectParametersBase {

		/// <summary>
		/// Should enable memory access for this connection
		/// </summary>
		public bool Enable { get; set; }
	}
}
