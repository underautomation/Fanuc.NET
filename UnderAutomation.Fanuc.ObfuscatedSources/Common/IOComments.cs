//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Contains input and output comment arrays for an I/O type.
	/// </summary>
	public class IOComments {


		public IOComments()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Array of input comments. Index 0 corresponds to Fanuc port 1.
		/// </summary>
		public string[] Inputs { get; set; }

		/// <summary>
		/// Array of output comments. Index 0 corresponds to Fanuc port 1.
		/// </summary>
		public string[] Outputs { get; set; }
	}
}
