//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Telnet {
	/// <summary>
	/// Event arguments for message received events.
	/// </summary>
	public class MessageReceivedEventArgs : EventArgs {

		/// <summary>
		/// Gets the message received from the controller.
		/// </summary>
		public string Message;


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public MessageReceivedEventArgs()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets a value indicating whether the message is a reset (empty message).
		/// </summary>
		public bool IsReset { get; }
	}
}
