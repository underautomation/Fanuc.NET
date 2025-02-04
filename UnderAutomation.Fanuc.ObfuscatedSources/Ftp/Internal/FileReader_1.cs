//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.IO;

namespace Ftp.Internal {
	/// <summary>
	/// File reader for specific files
	/// </summary>
	public abstract class FileReader<T> : FileReader, IFileReader<T>, IFileReader where T : IFanucContent {

		/// <summary>
		/// Read and decode the file on disc
		/// </summary>
		public T ReadFile(string filePath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read and decode the file stream
		/// </summary>
		public abstract T ReadFile(Stream fileStream, string fileName = null);
	}
}
