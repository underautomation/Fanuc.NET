//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common.Files.Diagnosis;
using Common.Files.List;
using Common.Files.Variables;

namespace Common.Files {
	/// <summary>
	/// Base class for Fanuc file client. It provides methods to read and parse known files such as summary diagnostic, error list, current position, ...
	/// </summary>
	public abstract class FileClientBase {

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
		public IOState GetIOState()
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
		/// Get controller program states
		/// </summary>
		public ProgramStates GetProgramStates()
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
		/// Get the list of all variable file names available on the controller
		/// </summary>
		public abstract string[] EnumerateVariableFileNames();

		/// <summary>
		/// Get the list of all variables on the controller. All variables files are read and decoded
		/// </summary>
		public VariableFileList GetAllVariables(OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// A list of method to read specific files
		/// </summary>
		public KnownVariableFiles KnownVariableFiles { get; }

		/// <summary>
		/// IP address of the controller
		/// </summary>
		public abstract string IP { get; }
	}
}
