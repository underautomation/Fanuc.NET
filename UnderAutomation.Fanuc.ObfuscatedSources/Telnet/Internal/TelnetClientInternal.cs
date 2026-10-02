//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.Telnet.Internal {
	/// <summary>
	/// Telnet KCL client created and managed by <see cref="UnderAutomation.Fanuc.FanucRobot"/>.
	/// Telnet KCL is a legacy protocol: it is not secured (password and commands are sent in clear text), and its behavior changes with the firmware version and on ROBOGUIDE. The same KCL commands are available on the web server of the controller with robot.Cgtp.Kcl (firmware V8.30 and later): prefer it for new developments.
	/// </summary>
	public class TelnetClientInternal : TelnetClientBase {
	}
}
