//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Cgtp {
	/// <summary>
	/// Sub-type of a TP program on the controller.
	/// </summary>
	public enum CgtpProgramSubType {

		/// <summary>
		/// No specific sub-type.
		/// </summary>
		None = 0,

		/// <summary>
		/// Job program.
		/// </summary>
		Job = 1,

		/// <summary>
		/// Process program.
		/// </summary>
		Process = 2,

		/// <summary>
		/// Macro program.
		/// </summary>
		Macro = 3,

		/// <summary>
		/// Condition handler program.
		/// </summary>
		Condition = 4,
	}
}
