//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Reason of the end of a Stream Motion session
	/// </summary>
	public enum SessionEndReason {

		/// <summary>
		/// The session was finished normally. The program continues after the IBGN end instruction.
		/// </summary>
		Finished = 0,

		/// <summary>
		/// The robot left the IBGN start instruction before the end of the session: program stopped, aborted, or alarm on the robot.
		/// </summary>
		ProgramStopped = 1,

		/// <summary>
		/// No status was received from the robot during the configured timeout
		/// </summary>
		StatusLost = 2,

		/// <summary>
		/// The client was disconnected
		/// </summary>
		Disconnected = 3,
	}
}
