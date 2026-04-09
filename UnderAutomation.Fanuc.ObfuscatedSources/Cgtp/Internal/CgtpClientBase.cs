//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Cgtp;
using Common;
using Cgtp.BatchVariables;

namespace Cgtp.Internal {
	/// <summary>
	/// Base implementation for the CGTP Web Server client.
	/// </summary>
	public abstract class CgtpClientBase {


		protected CgtpClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

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
		/// From firmware 9.10
		/// </summary>
		public void AbortTask(string progName = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Open the TP program <code class="paramref">progName</code> and move cursor to <code class="paramref">lineNum</code>.
		/// From firmware 9.10
		/// </summary>
		public void SelectProgram(string progName, int lineNum = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Delete the program <code class="paramref">progName</code> from the controller.
		/// From firmware 9.10
		/// </summary>
		/// <param name="progName">Program name</param>
		public void DeleteProgram(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get the comment of program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public string GetProgramComment(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set the comment of program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public void SetProgramComment(string progName, string comment)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get the owner of program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public string GetProgramOwner(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set the owner of program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public void SetProgramOwner(string progName, string owner)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get the stack size of program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public int GetProgramStackSize(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set the stack size of program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public void SetProgramStackSize(string progName, int stackSize)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get whether program <code class="paramref">progName</code> ignores pause requests.
		/// From firmware 9.10
		/// </summary>
		public bool GetProgramIgnorePause(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set whether program <code class="paramref">progName</code> ignores pause requests.
		/// From firmware 9.10
		/// </summary>
		public void SetProgramIgnorePause(string progName, bool ignorePause)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get whether program <code class="paramref">progName</code> is write-protected.
		/// From firmware 9.10
		/// </summary>
		public bool GetProgramWriteProtect(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set whether program <code class="paramref">progName</code> is write-protected.
		/// From firmware 9.10
		/// </summary>
		public void SetProgramWriteProtect(string progName, bool writeProtect)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get the sub-type of program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public CgtpProgramSubType GetProgramSubType(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set the sub-type of program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public void SetProgramSubType(string progName, CgtpProgramSubType subType)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Create a new TP program on the controller.
		/// From firmware 9.10
		/// </summary>
		/// <param name="progName">New program name</param>
		/// <param name="owner">Owner name (optional)</param>
		/// <param name="comment">Comment (optional)</param>
		/// <param name="defaultGroup">Default motion group (0 = omit)</param>
		/// <param name="subType">Program sub-type (default: None)</param>
		public void CreateProgram(string progName, string owner = null, string comment = null, int defaultGroup = 0, CgtpProgramSubType subType = CgtpProgramSubType.None)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Rename program <code class="paramref">sourceName</code> to <code class="paramref">newName</code>.
		/// From firmware 9.10
		/// </summary>
		public void RenameProgram(string sourceName, string newName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// List all TP or Karel programs on the controller
		/// </summary>
		/// <param name="type">TP or Karel</param>
		/// <param name="subType">Sub-type of the program (none, macro, job, ...)</param>
		public string[] ListPrograms(CgtpProgramType type, CgtpProgramSubType subType)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// List all TP programs on the controller, regardless of their sub-type.
		/// </summary>
		public string[] ListTpPrograms()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Delete <code class="paramref">count</code> lines starting at <code class="paramref">lineNum</code> in program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public void DeleteSourceLines(string progName, int lineNum, int count = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Insert a source line before <code class="paramref">lineNum</code> in program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public void InsertSourceLine(string progName, string lineContent, int lineNum)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Replace the source line at <code class="paramref">lineNum</code> in program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public void ReplaceSourceLine(string progName, string lineContent, int lineNum)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Run the specified program starting at <code class="paramref">lineNum</code>.
		/// From firmware 9.30
		/// </summary>
		public void RunProgram(string progName, int lineNum = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Change the active TP program to <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public void ChangeActiveProgram(string progName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Pause program execution on the controller.
		/// From firmware 9.10
		/// </summary>
		public void PauseAllPrograms()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read the value of variable <code class="paramref">varName</code> in program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		public string ReadVariableAsString(string varName, string progName = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read the typed value of variable <code class="paramref">varName</code> in program <code class="paramref">progName</code>.
		/// From firmware 9.10
		/// </summary>
		/// <param name="varName">Full variable name (e.g. "$RMT_MASTER").</param>
		/// <param name="progName">Program name, or null for system variables.</param>
		/// <returns>The variable value with its data type.</returns>
		public CgtpVariableValue ReadVariable(string varName, string progName = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write <code class="paramref">value</code> to variable <code class="paramref">varName</code> in program <code class="paramref">progName</code>.
		/// From firmware 8.30
		/// </summary>
		public void WriteVariable(string varName, string value, string progName = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Write an integer <code class="paramref">value</code> to variable <code class="paramref">varName</code> in program <code class="paramref">progName</code>.
		/// From firmware 8.30
		/// </summary>
		public void WriteVariable(string varName, int value, string progName = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Write a real (double) <code class="paramref">value</code> to variable <code class="paramref">varName</code> in program <code class="paramref">progName</code>.
		/// From firmware 8.30
		/// </summary>
		public void WriteVariable(string varName, double value, string progName = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Set the comment of a register or I/O port identified by <code class="paramref">type</code> and <code class="paramref">index</code>.
		/// </summary>
		/// <param name="type">The type of element to set the comment for.</param>
		/// <param name="index">1-based index of the element.</param>
		/// <param name="comment">The comment to set.</param>
		public void SetComment(CgtpCommentType type, int index, string comment)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Write a real (double) value to numeric register R[<code class="paramref">index</code>].
		/// </summary>
		/// <param name="index">1-based register index.</param>
		/// <param name="value">Value to write.</param>
		public void WriteNumericRegisterAsDouble(int index, double value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Write an integer value to numeric register R[<code class="paramref">index</code>].
		/// </summary>
		/// <param name="index">1-based register index.</param>
		/// <param name="value">Value to write.</param>
		public void WriteNumericRegisterAsInteger(int index, int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Write a string value to string register SR[<code class="paramref">index</code>].
		/// </summary>
		/// <param name="index">1-based register index.</param>
		/// <param name="value">String value to write.</param>
		public void WriteStringRegister(int index, string value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Set the severity of a user alarm.
		/// </summary>
		/// <param name="index">1-based alarm index.</param>
		/// <param name="severity">Severity value to set.</param>
		public void SetUserAlarmSeverity(int index, int severity)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read all numeric registers (R[]) with their comments and values.
		/// </summary>
		/// <returns>Array where index 0 corresponds to R[1], index 1 to R[2], etc.</returns>
		public NumericRegisterWithComment[] ReadNumericRegistersWithComment()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read all string registers (SR[]) with their comments and values.
		/// </summary>
		/// <returns>Array where index 0 corresponds to SR[1], index 1 to SR[2], etc.</returns>
		public StringRegisterWithComment[] ReadStringRegistersWithComment()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read all user alarm definitions with their comments and severity.
		/// </summary>
		/// <returns>Array where index 0 corresponds to User Alarm[1], index 1 to User Alarm[2], etc.</returns>
		public UserAlarmDefinition[] ReadUserAlarms()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read all I/O comments for the specified I/O type.
		/// </summary>
		/// <param name="type">The type of I/O pair to read comments for.</param>
		/// <returns>An <xref href="UnderAutomation.Fanuc.Common.IOComments" data-throw-if-not-resolved="false"></xref> containing input and output comment arrays.</returns>
		public IOComments GetIoComments(CgtpCommentIoType type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read all comments for the specified element type.
		/// For I/O types (RI, RO, DI, DO, GI, GO, AI, AO), returns the input or output comments accordingly.
		/// </summary>
		/// <param name="type">The type of element to read comments for.</param>
		/// <returns>Array of comments where index 0 corresponds to element 1.</returns>
		public string[] GetComments(CgtpCommentType type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read the numeric register (R[]) at <code class="paramref">index</code>.
		/// From firmware 9.10
		/// </summary>
		public NumericRegisterWithComment ReadNumericRegisterWithComment(int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read the position register (PR[]) at <code class="paramref">index</code> for motion group <code class="paramref">groupNum</code>.
		/// From firmware 9.10
		/// </summary>
		public PositionRegisterWithComment ReadPositionRegisterWithComment(int index, int groupNum = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read multiple variables from the controller in a single batch operation.
		/// Each variable in <code class="paramref">variables</code> will be updated with the value read from the controller.
		/// </summary>
		/// <param name="variables">Collection of variables to read. Each variable will have its value, Exists, IsUninitialized and IsReadOnly properties set after the call.</param>
		/// <returns>A result object containing the controller firmware version.</returns>
		public CgtpBatchReadResult ReadBatchVariables(CgtpBatchVariables variables)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Write a cartesian position value to a position register (PR[])
		/// </summary>
		/// <param name="index">1-based register index.</param>
		/// <param name="value">Cartesian position value to write.</param>
		/// <param name="groupNum">Motion group number (1-based). Default is 1.</param>
		public void WritePositionRegisterAsCartesian(int index, CartesianPosition value, int groupNum = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Write a joint position value to a position register (PR[])
		/// </summary>
		/// <param name="index">1-based register index.</param>
		/// <param name="value">Joint position value to write.</param>
		/// <param name="groupNum">Motion group number (1-based). Default is 1.</param>
		public void WritePositionRegisterAsJoint(int index, JointsPosition value, int groupNum = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Write multiple variables to the controller in a single batch operation.
		/// </summary>
		/// <param name="variables">Collection of variables to write. Each variable must have its value set before calling this method.</param>
		/// <returns>A result object.</returns>
		public CgtpBatchWriteResult WriteBatchVariables(CgtpBatchVariables variables)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read the value of I/O port at <code class="paramref">index</code> of type <code class="paramref">portType</code>.
		/// From firmware 8.30
		/// </summary>
		public int ReadIo(CgtpIoPortType portType, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set the value of I/O port at <code class="paramref">index</code> of type <code class="paramref">portType</code>.
		/// From firmware 8.30
		/// </summary>
		public void WriteIo(CgtpIoPortType portType, int index, int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Check whether I/O port at <code class="paramref">index</code> of type <code class="paramref">portType</code> is simulated.
		/// From firmware 8.30
		/// </summary>
		public bool GetIoSimulationStatus(CgtpIoPortType portType, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set I/O port at <code class="paramref">index</code> of type <code class="paramref">portType</code> to simulated.
		/// From firmware 8.30
		/// </summary>
		public void SimulateIo(CgtpIoPortType portType, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Remove simulation from I/O port at <code class="paramref">index</code> of type <code class="paramref">portType</code>.
		/// From firmware 8.30
		/// </summary>
		public void UnsimulateIo(CgtpIoPortType portType, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Read the current Cartesian position of motion group <code class="paramref">groupNum</code>.
		/// From firmware 9.10
		/// </summary>
		public CartesianPosition ReadCartesianPosition(int groupNum = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read the current joint angles of motion group <code class="paramref">groupNum</code>.
		/// From firmware 9.10
		/// </summary>
		public JointsPosition ReadJointPosition(int groupNum = 1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Compute the inverse kinematics on the controller: convert a Cartesian position to joint angles.
		/// </summary>
		/// <param name="group">Motion group number to use for kinematics calculation.</param>
		/// <param name="cartesianPosition">A Cartesian position to convert. Its StringValue is sent to the controller.</param>
		/// <param name="userTool">Optional user tool number to use for kinematics calculation, or -1 for flange.</param>
		/// <param name="userFrame">Optional user frame number to use for kinematics calculation, or -1 for world.</param>
		/// <returns>The corresponding joint position.</returns>
		public JointsPosition InvertKinematics(int group, CartesianPosition cartesianPosition, int userTool = -1, int userFrame = -1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Compute the forward kinematics on the controller: convert joint angles to a Cartesian position.
		/// </summary>
		/// <param name="group">Motion group number to use for kinematics calculation.</param>
		/// <param name="jointPosition">A joint position to convert. Its StringValue is sent to the controller.</param>
		/// <param name="userTool">Optional user tool number to use for kinematics calculation, or -1 for flange.</param>
		/// <param name="userFrame">Optional user frame number to use for kinematics calculation, or -1 for world.</param>
		/// <returns>The corresponding Cartesian position.</returns>
		public CartesianPosition ForwardKinematics(int group, JointsPosition jointPosition, int userTool = -1, int userFrame = -1)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// List files at the specified path on the controller.
		/// From firmware 9.40
		/// </summary>
		public string[] ListFiles(string pathName = "MD:")
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Download the content of a file from the controller as a string.
		/// From firmware 9.10
		/// </summary>
		/// <param name="pathName">File path on the controller (e.g. "MD:/filename.ls").</param>
		/// <returns>The file content as a string.</returns>
		public string GetFileAsString(string pathName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// KCL client for executing KCL commands over CGTP.
		/// </summary>
		public CgtpKclClient Kcl { get; }

		/// <summary>
		/// Provides methods to download and decode files from the controller via HTTP.
		/// </summary>
		public CgtpHttpClient Http { get; }

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
