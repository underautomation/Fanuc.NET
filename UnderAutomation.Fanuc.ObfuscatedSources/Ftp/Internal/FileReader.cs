//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Internal {
	/// <summary>
	/// Read and decode fanuc files
	/// </summary>
	public abstract class FileReader : IFileReader {

		/// <summary>
		/// File name
		/// </summary>
		public string FileName { get; }


		protected virtual void AfterParse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
