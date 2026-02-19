//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Telnet {
	/// <summary>
	/// Abstract base class for all KCL command results.
	/// </summary>
	public abstract class Result {

		/// <summary>
		/// During implementation, return true if it is assumed that the frame has finished being received.
		/// </summary>
		protected abstract bool FromResult(string data);


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Indicates that responses have been completed and received
		/// </summary>
		protected virtual void EndReceive()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		protected Result()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Error text if any error occured during command execution
		/// </summary>
		public string ErrorText { get; }

		/// <summary>
		/// Command succeeded if no error text is present
		/// </summary>
		public bool Succeed { get; }

		/// <summary>
		/// The KCL command that was sent to the controller
		/// </summary>
		public string KclCommand { get; }
	}
}
