//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Diagnosis {
	/// <summary>
	/// All diagnosis information
	/// </summary>
	public class SummaryDiagnosis : IFanucContent {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public SummaryDiagnosis()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// File name : summary.dg
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Current position of each robots and groups handled by this controller
		/// </summary>
		public CurrentPosition CurrentPosition { get; }

		/// <summary>
		/// Controller safety information
		/// </summary>
		public SafetyStatus Safety { get; }

		/// <summary>
		/// Controller IO status
		/// </summary>
		public IOState IOs { get; }

		/// <summary>
		/// Controller features status
		/// </summary>
		public Features Features { get; }

		/// <summary>
		/// Controller program states
		/// </summary>
		public ProgramStates ProgramStates { get; }
	}
}
