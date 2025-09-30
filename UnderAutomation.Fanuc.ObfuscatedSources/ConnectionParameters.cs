//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

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
		/// Sends commands to the robot for remote control
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
	}
}
