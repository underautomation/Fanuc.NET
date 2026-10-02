//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Fanuc.Telnet.Internal;

namespace UnderAutomation.Fanuc.Telnet {
	/// <summary>
	/// Standalone Telnet KCL client for direct use without <see cref="UnderAutomation.Fanuc.FanucRobot"/>.
	/// Telnet KCL is a legacy protocol: it is not secured (password and commands are sent in clear text), and its behavior changes with the firmware version and on ROBOGUIDE. The same KCL commands are available on the web server of the controller with Cgtp.CgtpClient.Kcl (firmware V8.30 and later): prefer it for new developments.
	/// </summary>
	public class TelnetClient : TelnetClientBase {

		/// <summary>
		/// Create a new instance of a robot communication
		/// </summary>
		public TelnetClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to a robot
		/// </summary>
		/// <param name="ip">IP or network name of the robot</param>
		/// <param name="telnetKclPassword">Telnet password associated with KCL user</param>
		public void Connect(string ip, string telnetKclPassword)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
