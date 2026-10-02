//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;
using System.Runtime.InteropServices;

namespace UnderAutomation.Fanuc.Ftp {
	/// <summary>
	/// Exception thrown when the controller refuses an FTP operation, or when the FTP communication fails.
	/// The message gives the reply of the controller and, when it is known, what to do.
	/// </summary>
	public class FtpException : Exception, ISerializable {

		/// <summary>
		/// Path of the file or folder on the controller concerned by the operation. Null when the operation has no path.
		/// </summary>
		public string RemotePath { get; }

		/// <summary>
		/// FTP reply code returned by the controller (for example 550). 0 when the controller did not reply.
		/// </summary>
		public int ReplyCode { get; }

		/// <summary>
		/// Reply text returned by the controller (for example "Specified program is in use"). Null when the controller did not reply.
		/// </summary>
		public string ReplyMessage { get; }

		/// <summary>
		/// True when the controller refused the operation because the program is in use: it is selected on the teach pendant
		/// or it runs. Select another program before you upload or delete it.
		/// </summary>
		public bool ProgramInUse { get; }
	}
}
