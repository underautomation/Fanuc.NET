//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp {
	/// <summary>
	/// Represents a file system object on the controller
	/// </summary>
	public class FtpListItem {

		/// <summary>
		/// Gets the size of the object. Only a few files (like *.tp or *.df) have a size that can be retrieved, for most files this is 0 even if they are not empty. For directories this is always 0.
		/// </summary>
		public long Size { get; }

		/// <summary>
		/// Gets the file permissions in the CHMOD format.
		/// </summary>
		public int Chmod { get; }

		/// <summary>
		/// Gets the created date of the object.
		/// </summary>
		public DateTime Created { get; }

		/// <summary>
		/// Gets the full path name to the object.
		/// </summary>
		public string FullName { get; }

		/// <summary>
		/// Gets name to the object.
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Gets the last write time of the object.
		/// </summary>
		public DateTime Modified { get; }

		/// <summary>
		/// Gets the type of file system object.
		/// </summary>
		public FtpFileSystemObjectType Type { get; }
	}
}
