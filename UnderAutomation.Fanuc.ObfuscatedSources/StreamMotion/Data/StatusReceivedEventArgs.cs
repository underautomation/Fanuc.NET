//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.StreamMotion.Data {
	/// <summary>
	/// Arguments of the StatusReceived event
	/// </summary>
	public class StatusReceivedEventArgs : EventArgs {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Last status received from the robot
		/// </summary>
		public StreamMotionStatus Status { get; }
	}
}
