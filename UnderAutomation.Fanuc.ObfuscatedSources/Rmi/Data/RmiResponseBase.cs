//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Base class for RMI responses that return an error id from the controller.
	/// </summary>
	public class RmiResponseBase {


		public RmiResponseBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Error identifier. 0 means success; non-zero indicates a controller error.
		/// </summary>
		public int ErrorId { get; set; }
	}
}
