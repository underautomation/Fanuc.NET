//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Arguments of the SessionEnded event
	/// </summary>
	public class SessionEndedEventArgs : SessionEventArgs {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reason of the end of the session
		/// </summary>
		public SessionEndReason Reason { get; }
	}
}
