//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Fanuc.Common;

namespace UnderAutomation.Fanuc {
	/// <summary>
	/// Connection parameters
	/// </summary>
	public class ConnectionParameters {

		/// <summary>
		/// Instanciate a new connection parameters
		/// </summary>
		public ConnectionParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Instanciate a new connection parameters with a specified address
		/// </summary>
		public ConnectionParameters(string address)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Address of the robot (IP, host name, or path to ROBOGUIDE project folder)
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Send a ping command before initializing any connections
		/// </summary>
		public bool PingBeforeConnect { get; set; }

		/// <summary>
		/// Controller language (default: English)
		/// </summary>
		public Languages Language { get; set; }

		/// <summary>
		/// Parameters of the Telnet KCL client, which sends commands to the robot for remote control.
		/// Telnet KCL is a legacy protocol: it is not secured (password and commands are sent in clear text), and its behavior changes with the firmware version and on ROBOGUIDE. The same KCL commands are available on the web server of the controller with robot.Cgtp.Kcl (firmware V8.30 and later): prefer it for new developments.
		/// </summary>
		public TelnetConnectParameters Telnet { get; set; }

		/// <summary>
		/// Access controller internal memory to read variables, IO, positions, diagnosis, ...
		/// </summary>
		public FtpConnectParameters Ftp { get; set; }

		/// <summary>
		/// Read and write IOs, read and clear alarms, read current program tasks
		/// </summary>
		public SnpxConnectParameters Snpx { get; set; }

		/// <summary>
		/// Parameters for RMI (Remote Motion Interface)
		/// </summary>
		public RmiConnectParameters Rmi { get; set; }

		/// <summary>
		/// Parameters for Stream Motion (J519 option) - real-time streaming motion control over UDP
		/// </summary>
		public StreamMotionConnectParameters StreamMotion { get; set; }

		/// <summary>
		/// Parameters of the CGTP client, which uses the web server of the controller (HTTP)
		/// </summary>
		public CgtpConnectParameters Cgtp { get; set; }
	}
}
