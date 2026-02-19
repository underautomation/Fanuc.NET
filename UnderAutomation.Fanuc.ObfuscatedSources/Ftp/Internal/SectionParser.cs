//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Ftp.Internal {
	/// <summary>
	/// Abstract base class for parsing sections of diagnostic files.
	/// </summary>
	public abstract class SectionParser {

		/// <summary>
		/// Determines whether this parser can handle the given section header line.
		/// </summary>
		/// <param name="line">The header line to check.</param>
		/// <returns><code>true</code> if this parser handles the section; otherwise <code>false</code>.</returns>
		public virtual bool CanHandleSection(string line)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Parses a single line from the section content.
		/// </summary>
		/// <param name="line">The line to parse.</param>
		public abstract void ParseLine(string line);

		/// <summary>
		/// Called after all lines have been parsed. Override to perform final processing.
		/// </summary>
		public virtual void AfterParse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		protected SectionParser()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Gets the possible section header strings that indicate the start of this section.
		/// </summary>
		public virtual string[] SectionStart { get; }

		/// <summary>
		/// Gets or sets a value indicating whether the end of the file or section has been reached.
		/// </summary>
		public virtual bool EndOfFile { get; set; }
	}
}
