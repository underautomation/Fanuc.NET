//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// I/O types supported by Stream Motion protocol
	/// </summary>
	public enum IOType : byte {

		/// <summary>
		/// No I/O operation
		/// </summary>
		None = 0,

		/// <summary>
		/// Digital Input
		/// </summary>
		DI = 1,

		/// <summary>
		/// Digital Output
		/// </summary>
		DO = 2,

		/// <summary>
		/// Robot Input
		/// </summary>
		RI = 8,

		/// <summary>
		/// Robot Output
		/// </summary>
		RO = 9,

		/// <summary>
		/// System Input
		/// </summary>
		SI = 11,

		/// <summary>
		/// System Output
		/// </summary>
		SO = 12,

		/// <summary>
		/// Weld Input
		/// </summary>
		WI = 16,

		/// <summary>
		/// Weld Output
		/// </summary>
		WO = 17,

		/// <summary>
		/// User Input
		/// </summary>
		UI = 20,

		/// <summary>
		/// User Output
		/// </summary>
		UO = 21,

		/// <summary>
		/// Weld System Input
		/// </summary>
		WSI = 26,

		/// <summary>
		/// Weld System Output
		/// </summary>
		WSO = 27,

		/// <summary>
		/// Flag
		/// </summary>
		F = 35,

		/// <summary>
		/// Marker
		/// </summary>
		M = 36,
	}
}
