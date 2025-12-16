//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace Common {
	/// <summary>
	/// Exception thrown when connection to the robot fails
	/// </summary>
	public class ConnectException : Exception, ISerializable {


		public string Service { get; }


		public string RobotIp { get; }
	}
}
