//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Ftp.Internal;
using System;

namespace Ftp.Diagnosis {
	/// <summary>
	/// Parser for reading and interpreting safety status signals from diagnostic files.
	/// </summary>
	public class SafetyStatusParser : SectionParser<SafetyStatus> {

		/// <summary>
		/// Parses a single line, checking if it starts with the specified prefix and extracting a boolean value.
		/// </summary>
		/// <param name="line">The line to parse.</param>
		/// <param name="start">The expected line prefix.</param>
		/// <param name="setValue">Action to set the parsed boolean value.</param>
		public void ParseLine(string line, string start, Action<bool> setValue)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Parses a single line from the section content.
		/// </summary>
		/// <param name="line">The line to parse.</param>
		public override void ParseLine(string line)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public SafetyStatusParser()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the possible section header strings that indicate the start of this section.
		/// </summary>
		public override string[] SectionStart => default;
	}
}
