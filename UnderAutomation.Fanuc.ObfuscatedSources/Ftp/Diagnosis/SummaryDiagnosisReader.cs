//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;
using System.IO;
using Common;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Read and parse the file summary.dg
	/// </summary>
	public class SummaryDiagnosisReader : FileReader<SummaryDiagnosis>, IFileReader<SummaryDiagnosis>, IFileReader {

		/// <summary>
		/// Read and parse the file
		/// </summary>
		public override SummaryDiagnosis ReadFile(Stream fileStream, Languages language, string fileName)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
