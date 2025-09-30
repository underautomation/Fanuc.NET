//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Base class for responses that include a sequence identifier.
	/// </summary>
	public class RmiSequenceResponse : RmiResponseBase {


		public RmiSequenceResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Echoed SequenceID of the instruction that completed.
		/// </summary>
		public int SequenceId { get; set; }
	}
}
