//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.IO;

namespace Ftp.Internal {
	/// <summary>
	/// Interface for Fanuc file readers
	/// </summary>
	public interface IFileReader<out T> : IFileReader where T : IFanucContent {

		/// <summary>
		/// Reads file by path and decodes it
		/// </summary>
		T ReadFile(string filePath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reads file stream and decodes it
		/// </summary>
		T ReadFile(Stream fileStream, string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
