//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;
using System.IO;

namespace Ftp.Diagnosis {

	public class DiagnosisReader<T, U> : FileReader<T>, IFileReader<T>, IFileReader where T : IFanucContent, new() where U : SectionParser<T>, new() {

		/// <summary>
		/// Read and decode the file stream
		/// </summary>
		public override T ReadFile(Stream fileStream, string fileName = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
