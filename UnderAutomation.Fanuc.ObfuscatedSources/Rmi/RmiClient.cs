//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Rmi.Internal;

namespace Rmi {
	/// <summary>
	/// RMI client for connecting to and controlling FANUC robots via the Remote Motion Interface protocol.
	/// </summary>
	public class RmiClient : RmiClientBase, IDisposable {

		/// <summary>
		/// Creates a new instance of the RMI client.
		/// </summary>
		public RmiClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to the FANUC controller using the RMI protocol.
		/// </summary>
		/// <param name="ip">Controller IP address or hostname.</param>
		/// <param name="port">Bootstrap port number.</param>
		/// <param name="readTimeoutMs">Read timeout in milliseconds.</param>
		/// <param name="writeTimeoutMs">Write timeout in milliseconds.</param>
		public void Connect(string ip, int port = 16001, int readTimeoutMs = 3000, int writeTimeoutMs = 3000)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
