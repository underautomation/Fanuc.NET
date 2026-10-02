//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Fanuc.Common.Kcl;

namespace UnderAutomation.Fanuc.Cgtp.Internal {
	/// <summary>
	/// KCL client that uses the web server of the controller (CGTP) instead of Telnet. It has the same commands as the Telnet KCL client and does not need a Telnet password.
	/// Some commands (Abort, AbortAll, ClearProgram, ClearVars, Continue, Hold, Pause, Run, StepOn, StepOff, SendCustomCommandUnsafe) are sent in Unsafe mode, from firmware V9.30:
	/// the controller returns no status, the result always reports a success, and you cannot know if the command was executed.
	/// Check the state of the controller after the command, for example with GetTaskInformation() or by reading a variable.
	/// To start a program, prefer robot.Cgtp.RunProgram() (firmware V9.30 and later): it can start at a given line and throws a CgtpException when the controller refuses the command.
	/// </summary>
	public class CgtpKclClient : KclClientBase {

		/// <summary>
		/// Sends a custom KCL command in Unsafe mode. Success or failure cannot be determined from the result.
		/// </summary>
		/// <param name="command">Custom command to send</param>
		public CustomCommandResult SendCustomCommandUnsafe(string command)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sends a KCL command through the web server of the controller and returns its result.
		/// </summary>
		protected override T SendKcl<T>(string command) where T : Result, new()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Sends a KCL command in Unsafe mode through the CGTP client.
		/// In this mode, the command is always reported as successful because the controller does not return any status or error information.
		/// </summary>
		protected override T SendKclUnsafe<T>(string command) where T : Result, new()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Indicates whether the KCL client is currently connected.
		/// </summary>
		public bool Enabled { get; }
	}
}
