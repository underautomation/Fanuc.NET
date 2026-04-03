//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common.Files;
using Ftp;
using Common;

namespace Ftp.Internal {
	/// <summary>
	/// Base class for FTP features
	/// </summary>
	public abstract class FtpClientBase : FileClientBase {

		/// <summary>
		/// Disconnects from FTP server
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get a list of all variable files on controller
		/// </summary>
		public FtpListItem[] EnumerateVariableFiles()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the list of all variable file names available on the controller
		/// </summary>
		public override string[] EnumerateVariableFileNames()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Connect robot IP address or host name
		/// </summary>
		public override string IP => default;

		/// <summary>
		/// Controller language (default is English)
		/// </summary>
		public Languages Language { get; set; }

		/// <summary>
		/// Indicates that FTP connection is active
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Contains methods to manipulate files and folders on the controller (upload, download, delete, ...)
		/// </summary>
		public FtpDirectFileHandling DirectFileHandling { get; }
	}
}
