//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rmi.Internal;

namespace Common {
	/// <summary>
	/// RMI parameters
	/// </summary>
	public class RmiConnectParameters : RmiConnectParametersBase {


		public RmiConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Should enable RMI for this connection (default: false)
		/// </summary>
		public bool Enable { get; set; }
	}
}
