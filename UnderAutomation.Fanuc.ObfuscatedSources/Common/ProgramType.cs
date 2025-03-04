//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Common {
	/// <summary>
	/// Represents the type of a program.
	/// </summary>
	public enum ProgramType {

		/// <summary>
		/// The program type is unknown.
		/// </summary>
		Unknown = 0,

		/// <summary>
		/// The program is a Karel program, also known as PC (Programmable Control).
		/// </summary>
		Karel = 1,

		/// <summary>
		/// The program is a TP (Teach Pendant) program.
		/// </summary>
		TP = 2,
	}
}
