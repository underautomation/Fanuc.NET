//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Fanuc.Telnet.Internal;

namespace UnderAutomation.Fanuc.Common {
	/// <summary>
	/// Connection parameters of the Telnet KCL client (remote commands).
	/// Telnet KCL is a legacy protocol: it is not secured (password and commands are sent in clear text), and its behavior changes with the firmware version and on ROBOGUIDE. The same KCL commands are available on the web server of the controller with robot.Cgtp.Kcl (firmware V8.30 and later): prefer it for new developments.
	/// </summary>
	public class TelnetConnectParameters : TelnetConnectParametersBase {


		public TelnetConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Should use this service (default: false). Prefer robot.Cgtp.Kcl, enabled by default, for new developments.
		/// </summary>
		public bool Enable { get; set; }
	}
}
