//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Parser for reading and interpreting IO state data from diagnostic files.
	/// </summary>
	public class IOStateParser : SectionParser<IOState> {

		/// <summary>
		/// Parses a single line from the section content.
		/// </summary>
		/// <param name="line">The line to parse.</param>
		public override void ParseLine(string line)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Called after all lines have been parsed. Override to perform final processing.
		/// </summary>
		public override void AfterParse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public IOStateParser()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the possible section header strings that indicate the start of this section.
		/// </summary>
		public override string[] SectionStart => default;
	}
}
