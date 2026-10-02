//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.IO;

namespace UnderAutomation.Fanuc.Common.Files.Diagnosis {
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
