//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Snpx.Internal;

namespace Common {
	/// <summary>
	/// Memory access parameters
	/// </summary>
	public class SnpxConnectParameters : SnpxConnectParametersBase {


		public SnpxConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Should enable memory access for this connection (default: false)
		/// </summary>
		public bool Enable { get; set; }
	}
}
