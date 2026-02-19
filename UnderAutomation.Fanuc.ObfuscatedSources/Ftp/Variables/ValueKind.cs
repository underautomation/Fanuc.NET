//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Variables {
	/// <summary>
	/// Describes the kind of a variable value
	/// </summary>
	public enum ValueKind {

		/// <summary>
		/// A single scalar value
		/// </summary>
		Value = 0,

		/// <summary>
		/// An array of values
		/// </summary>
		Array = 1,

		/// <summary>
		/// A structured type with named fields
		/// </summary>
		Structure = 2,

		/// <summary>
		/// A file-level container
		/// </summary>
		File = 3,
	}
}
