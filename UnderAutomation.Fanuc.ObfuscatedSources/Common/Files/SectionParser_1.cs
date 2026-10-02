//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Fanuc.Common.Files {
	/// <summary>
	/// Abstract generic section parser that creates and populates a section of type <code class="typeparamref">T</code>.
	/// </summary>
	public abstract class SectionParser<T> : SectionParser where T : new() {

		/// <summary>
		/// The parsed section instance.
		/// </summary>
		public readonly T Section;

		/// <summary>
		/// Initializes a new instance of the <see cref="UnderAutomation.Fanuc.Common.Files.SectionParser`1"/> class.
		/// </summary>
		public SectionParser()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
