//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Event arguments for state received events
	/// </summary>
	public class StateReceivedEventArgs : EventArgs {

		/// <summary>
		/// Creates a new instance of StateReceivedEventArgs
		/// </summary>
		/// <param name="state">The state packet received from the robot</param>
		public StateReceivedEventArgs(StatePacket state)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// The state packet received from the robot
		/// </summary>
		public StatePacket State { get; }
	}
}
