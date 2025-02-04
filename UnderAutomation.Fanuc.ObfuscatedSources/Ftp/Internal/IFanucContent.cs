//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Internal {
	/// <summary>
	/// Interface of a file that comes from a Fanuc controller
	/// </summary>
	public interface IFanucContent {

		/// <summary>
		/// File name
		/// </summary>
		string Name { get; }
	}
}
