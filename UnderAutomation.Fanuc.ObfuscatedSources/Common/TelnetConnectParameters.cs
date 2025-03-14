//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Telnet.Internal;

namespace Common {
	/// <summary>
	/// Connect parameters for remote command
	/// </summary>
	public class TelnetConnectParameters : TelnetConnectParametersBase {


		public TelnetConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Should use this service (default: true)
		/// </summary>
		public bool Enable { get; set; }
	}
}
