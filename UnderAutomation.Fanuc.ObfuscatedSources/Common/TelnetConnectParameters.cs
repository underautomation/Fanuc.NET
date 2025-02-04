//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Telnet.Internal;

namespace Common {
	/// <summary>
	/// Connect parameters for remote command
	/// </summary>
	public class TelnetConnectParameters : TelnetConnectParametersBase {

		/// <summary>
		/// Should use this service
		/// </summary>
		public bool Enable { get; set; }
	}
}
