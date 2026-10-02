//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.StreamMotion.Data {
	/// <summary>
	/// State of a Stream Motion client
	/// </summary>
	public enum StreamMotionState {

		/// <summary>
		/// The client is not connected
		/// </summary>
		Disconnected = 0,

		/// <summary>
		/// The client is connected but the robot does not send its status (call StartMonitoring)
		/// </summary>
		Connected = 1,

		/// <summary>
		/// The robot sends its status, but no program is waiting on an IBGN start instruction
		/// </summary>
		Monitoring = 2,

		/// <summary>
		/// A program is waiting on an IBGN start instruction and the robot accepts positions
		/// </summary>
		Ready = 3,

		/// <summary>
		/// Positions are sent to the robot every communication cycle
		/// </summary>
		Streaming = 4,

		/// <summary>
		/// The last position was sent. The client waits for the robot to leave the IBGN start instruction.
		/// </summary>
		Finishing = 5,
	}
}
