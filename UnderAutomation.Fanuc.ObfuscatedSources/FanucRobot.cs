//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using License;
using Telnet.Internal;
using Ftp.Internal;
using Snpx.Internal;
using Rmi.Internal;
using StreamMotion.Internal;

namespace UnderAutomation.Fanuc {
	/// <summary>
	/// Main class of the SDK that represents a connection to a Fanuc robot
	/// </summary>
	public class FanucRobot {

		/// <summary>
		/// Instanciate a new Fanuc robot connection
		/// </summary>
		public FanucRobot()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to robot by IP with default connection parameters
		/// </summary>
		public void Connect(string ip)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initialize a conenction to the robot with specified parameters
		/// </summary>
		public void Connect(ConnectionParameters parameters)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Disconnect all services connected to the robot
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// If you have a license And a key, please call this static method to register the product And exit the trial period
		/// ou can register a product even if the trial period has ended
		/// </summary>
		/// <param name="licensee">Your organization name</param>
		/// <param name="key">The associated key supplied by UnderAutomation</param>
		/// <returns>Information about the supplied license</returns>
		public static LicenseInfo RegisterLicense(string licensee, string key)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// IP or robot name
		/// </summary>
		public string Address { get; }

		/// <summary>
		/// Indicates whether any service is currently connected to the robot
		/// </summary>
		public bool Enabled { get; }

		/// <summary>
		/// Telnet client for remote command execution
		/// </summary>
		public TelnetClientInternal Telnet { get; }

		/// <summary>
		/// FTP client for memory and file access
		/// </summary>
		public FtpClientInternal Ftp { get; }

		/// <summary>
		/// SNPX client for IO, alarms and task reading
		/// </summary>
		public SnpxClientInternal Snpx { get; }

		/// <summary>
		/// RMI client for remote motion interface
		/// </summary>
		public RmiClientInternal Rmi { get; }

		/// <summary>
		/// Stream Motion client for real-time motion control
		/// </summary>
		public StreamMotionClientInternal StreamMotion { get; }

		/// <summary>
		/// Return information about your license
		/// </summary>
		public static LicenseInfo LicenseInfo { get; }
	}
}
