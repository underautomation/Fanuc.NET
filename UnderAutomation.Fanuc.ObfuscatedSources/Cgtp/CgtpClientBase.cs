//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace Cgtp {
	/// <summary>
	/// Base implementation for the CGTP Web Server client.
	/// </summary>
	public abstract class CgtpClientBase {

		/// <summary>
		/// Disconnect from the CGTP Web Server. After calling this method, the client must be reconnected before it can be used again.
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Abort the task specified by <code class="paramref">progName</code>.
		/// Set to null to abort all user tasks.
		/// </summary>
		public void AbortTask(string progName = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Open the TP program <code class="paramref">progName</code> and move cursor to <code class="paramref">lineNum</code>.
		/// </summary>
		public void SelectProgram(string progName, int lineNum = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Delete the program <code class="paramref">progName</code> from the controller.
		/// </summary>
		/// <param name="progName">Program name</param>
		public void DeleteProgram(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get the comment of program <code class="paramref">progName</code>.
		/// </summary>
		public string GetProgramComment(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set the comment of program <code class="paramref">progName</code>.
		/// </summary>
		public void SetProgramComment(string progName, string comment)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get the owner of program <code class="paramref">progName</code>.
		/// </summary>
		public string GetProgramOwner(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set the owner of program <code class="paramref">progName</code>.
		/// </summary>
		public void SetProgramOwner(string progName, string owner)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get the stack size of program <code class="paramref">progName</code>.
		/// </summary>
		public int GetProgramStackSize(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set the stack size of program <code class="paramref">progName</code>.
		/// </summary>
		public void SetProgramStackSize(string progName, int stackSize)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get whether program <code class="paramref">progName</code> ignores pause requests.
		/// </summary>
		public bool GetProgramIgnorePause(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set whether program <code class="paramref">progName</code> ignores pause requests.
		/// </summary>
		public void SetProgramIgnorePause(string progName, bool ignorePause)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get whether program <code class="paramref">progName</code> is write-protected.
		/// </summary>
		public bool GetProgramWriteProtect(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set whether program <code class="paramref">progName</code> is write-protected.
		/// </summary>
		public void SetProgramWriteProtect(string progName, bool writeProtect)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get the sub-type of program <code class="paramref">progName</code>.
		/// </summary>
		public ProgramSubType GetProgramSubType(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set the sub-type of program <code class="paramref">progName</code>.
		/// </summary>
		public void SetProgramSubType(string progName, ProgramSubType subType)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Create a new TP program on the controller.
		/// </summary>
		/// <param name="progName">New program name</param>
		/// <param name="owner">Owner name (optional)</param>
		/// <param name="comment">Comment (optional)</param>
		/// <param name="defaultGroup">Default motion group (0 = omit)</param>
		/// <param name="subType">Program sub-type (default: None)</param>
		public void CreateProgram(string progName, string owner = null, string comment = null, int defaultGroup = 0, ProgramSubType subType = ProgramSubType.None)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Rename program <code class="paramref">sourceName</code> to <code class="paramref">newName</code>.
		/// </summary>
		public void RenameProgram(string sourceName, string newName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Run the specified program starting at <code class="paramref">lineNum</code>.
		/// </summary>
		public void RunProgram(string progName, int lineNum = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Change the active TP program to <code class="paramref">progName</code>.
		/// </summary>
		public void ChangeActiveProgram(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Pause program execution on the controller.
		/// </summary>
		public void PauseAllPrograms()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read the value of variable <code class="paramref">varName</code> in program <code class="paramref">progName</code>.
		/// </summary>
		public string ReadVariableAsString(string varName, string progName = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write <code class="paramref">value</code> to variable <code class="paramref">varName</code> in program <code class="paramref">progName</code>.
		/// </summary>
		public void WriteVariable(string varName, string value, string progName = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// List files at the specified path on the controller.
		/// </summary>
		public string[] ListFiles(string pathName = "MD:")
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public string GetFileAsString(string pathName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected CgtpClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Controller language (default is English)
		/// </summary>
		public Languages Language { get; set; }

		/// <summary>
		/// Indicates whether the client is currently connected to the CGTP Web Server.
		/// </summary>
		public bool Enabled { get; }
	}
}
