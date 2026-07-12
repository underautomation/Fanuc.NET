//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Result of reading the most recent controller error text.
	/// </summary>
	public class RmiControllerErrorTextResponse : RmiResponseBase {


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


		public RmiControllerErrorTextResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Error entries in the form XXXX-NNN (up to 5 entries).
		/// </summary>
		public string[] ErrorDataEntries { get; set; }

		/// <summary>
		/// First error entry, or an empty string when none.
		/// </summary>
		public string ErrorData { get; }
	}
}
