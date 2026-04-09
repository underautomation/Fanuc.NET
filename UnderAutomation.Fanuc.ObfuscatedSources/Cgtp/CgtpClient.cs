//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Cgtp.Internal;

namespace Cgtp {
	/// <summary>
	/// Standalone CGTP Web Server client for direct use without <xref href="UnderAutomation.Fanuc.FanucRobot" data-throw-if-not-resolved="false"></xref>.
	/// </summary>
	public class CgtpClient : CgtpClientBase {

		/// <summary>
		/// Creates a new instance of the CGTP Web Server client.
		/// </summary>
		public CgtpClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to the CGTP Web Server on the controller.
		/// </summary>
		/// <param name="ip">Controller IP address or hostname.</param>
		/// <param name="port">HTTP port number (default: 3080).</param>
		/// <param name="requestTimeoutMs">Request timeout in milliseconds (default: 3000).</param>
		/// <param name="login">Login for HTTP Basic authentication (optional).</param>
		/// <param name="password">Password for HTTP Basic authentication (optional).</param>
		public void Connect(string ip, int port = 3080, int requestTimeoutMs = 3000, string login = null, string password = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
