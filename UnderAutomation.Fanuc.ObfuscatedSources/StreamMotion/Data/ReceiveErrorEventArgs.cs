//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Event arguments for receive error events
	/// </summary>
	public class ReceiveErrorEventArgs : EventArgs {

		/// <summary>
		/// Creates a new instance of ReceiveErrorEventArgs
		/// </summary>
		/// <param name="exception">The exception that occurred</param>
		/// <param name="isStreaming">Whether streaming is still active</param>
		public ReceiveErrorEventArgs(Exception exception, bool isStreaming)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// The exception that occurred during receiving
		/// </summary>
		public Exception Exception { get; }

		/// <summary>
		/// Indicates whether streaming is still active after the error
		/// </summary>
		public bool IsStreaming { get; }
	}
}
