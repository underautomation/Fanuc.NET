//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Parser for the "TASK STATES" section, renamed from ProgramStatesReader to ProgramStatesParser.
	/// Uses compiled Regex for efficiency.
	/// </summary>
	public class ProgramStatesParser : SectionParser<ProgramStates> {


		public override void ParseLine(string line)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override void AfterParse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public ProgramStatesParser()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string[] SectionStart => default;
	}
}
