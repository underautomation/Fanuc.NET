//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Telnet {
	/// <summary>
	/// Result of a program command (abort, continue, hold, pause, run, etc.).
	/// </summary>
	public class ProgramCommandResult : Result {

		/// <summary>
		/// During implementation, return true if it is assumed that the frame has finished being received.
		/// </summary>
		protected override bool FromResult(string data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Indicates that responses have been completed and received
		/// </summary>
		protected override void EndReceive()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public ProgramCommandResult()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
