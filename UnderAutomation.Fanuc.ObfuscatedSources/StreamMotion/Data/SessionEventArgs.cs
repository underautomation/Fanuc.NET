//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Arguments of the session events
	/// </summary>
	public class SessionEventArgs : EventArgs {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Index of the session since the connection (starts at 1)
		/// </summary>
		public int SessionIndex { get; }
	}
}
