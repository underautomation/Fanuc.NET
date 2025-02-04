//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Diagnosis;
using Ftp.List;
using Ftp.Variables;
using Ftp;

namespace Ftp.Internal {
	/// <summary>
	/// Base class for FTP features
	/// </summary>
	public abstract class FtpClientBase {

		/// <summary>
		/// Connect robot IP address or host name
		/// </summary>
		public string IP { get; }

		/// <summary>
		/// Indicates that FTP connection is active
		/// </summary>
		public bool Connected { get; }

		/// <summary>
		/// Disconnects from FTP server
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Contains methods to manipulate files and folders on the controller (upload, download, delete, ...)
		/// </summary>
		public FtpDirectFileHandling DirectFileHandling { get; }

		/// <summary>
		/// A list of method to read specific files
		/// </summary>
		public FtpKnownVariableFiles KnownVariableFiles { get; }

		/// <summary>
		/// Get controller status (position, safety, ios, ...)
		/// </summary>
		public SummaryDiagnosis GetSummaryDiagnostic()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get a list of all errors logged by the controller
		/// </summary>
		public ErrorList GetAllErrorsList()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get current robot position of each robot handled by this controller
		/// </summary>
		public CurrentPosition GetCurrentPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get controller IO State
		/// </summary>
		public IOState GetIOState(FtpDirectFileHandling.OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get controller safety status
		/// </summary>
		public SafetyStatus GetSafetyStatus()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get and parse a variable file from its name
		/// </summary>
		public GenericVariableFile GetVariablesFromFile(string variableFileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
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
		/// Get the list of all variables on the controller. All variables files are read and decoded
		/// </summary>
		public VariableFileList GetAllVariables(FtpDirectFileHandling.OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
