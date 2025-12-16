//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Variables;
using Ftp.List;
using Ftp.Diagnosis;
using Common;
using Ftp.Internal;
using System.IO;

namespace Ftp {
	/// <summary>
	/// Contains static functions to decode Fanuc files (variables, diagnosis, listing, ...)
	/// </summary>
	public static class FanucFileReaders {

		/// <summary>
		/// Helper to read variable files *.va
		/// </summary>
		public static readonly VariableReader VariableReader;

		/// <summary>
		/// Helper to read error files like errall.ls
		/// </summary>
		public static readonly ErrorListReader ErrorListReader;

		/// <summary>
		/// Helper to read summary diagnosis file summary.dg
		/// </summary>
		public static readonly SummaryDiagnosisReader SummaryDiagnosticReader;

		/// <summary>
		/// Decode current position file curpos.dg
		/// </summary>
		public static readonly DiagnosisReader<CurrentPosition, CurrentPositionReader> CurrentPositionReader;

		/// <summary>
		/// Decode IO Status file iostate.dg
		/// </summary>
		public static readonly DiagnosisReader<IOState, IOStateParser> IOStateReader;

		/// <summary>
		/// Decode IO Status file iostate.dg
		/// </summary>
		public static readonly DiagnosisReader<SafetyStatus, SafetyStatusParser> SafetyStatusReader;

		/// <summary>
		/// Decode task and program states prgstate.dg
		/// </summary>
		public static readonly DiagnosisReader<ProgramStates, ProgramStatesParser> ProgramStates;

		/// <summary>
		/// Read any file by path on disc, recognize it by name and decode it
		/// </summary>
		public static IFanucContent ReadFile(string fileName, Languages language)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read any file by path on disc, recognize it by name and decode it
		/// </summary>
		public static IFanucContent ReadFile(Stream fileStream, string fileName, Languages language)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the collection of all parsers
		/// </summary>
		public static IFileReader<IFanucContent>[] Readers { get; }
	}
}
