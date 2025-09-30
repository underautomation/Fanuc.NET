//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Result of reading the most recent error text.
	/// </summary>
	public class ControllerErrorText : RmiResponseBase {


		public ControllerErrorText()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Controller error text in the form XXXX-NNN.
		/// </summary>
		public string ErrorData { get; set; }
	}
}
