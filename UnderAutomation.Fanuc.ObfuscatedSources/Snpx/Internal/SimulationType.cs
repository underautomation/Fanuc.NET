//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Identifies the type of I/O for which simulation status can be read or written.
	/// </summary>
	public enum SimulationType {

		/// <summary>
		/// Digital Input.
		/// </summary>
		DI = 0,

		/// <summary>
		/// Digital Output.
		/// </summary>
		DO = 1,

		/// <summary>
		/// Remote Input.
		/// </summary>
		RI = 2,

		/// <summary>
		/// Remote Output.
		/// </summary>
		RO = 3,

		/// <summary>
		/// Weld Input.
		/// </summary>
		WI = 4,

		/// <summary>
		/// Weld Output.
		/// </summary>
		WO = 5,

		/// <summary>
		/// Wire Stick Input.
		/// </summary>
		WSI = 6,

		/// <summary>
		/// Wire Stick Output.
		/// </summary>
		WSO = 7,

		/// <summary>
		/// Group Input.
		/// </summary>
		GI = 8,

		/// <summary>
		/// Group Output.
		/// </summary>
		GO = 9,

		/// <summary>
		/// Analog Input.
		/// </summary>
		AI = 10,

		/// <summary>
		/// Analog Output.
		/// </summary>
		AO = 11,
	}
}
