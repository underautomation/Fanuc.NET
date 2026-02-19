//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Telnet {
	/// <summary>
	/// Result of a custom KCL command.
	/// </summary>
	public class CustomCommandResult : Result {

		/// <summary>
		/// During implementation, return true if it is assumed that the frame has finished being received.
		/// </summary>
		protected override bool FromResult(string data)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public CustomCommandResult()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the raw data returned by the custom command.
		/// </summary>
		public string Data { get; }
	}
}
