//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Identifies the type of I/O segment.
	/// </summary>
	public enum SegmentName {

		/// <summary>
		/// Safety Digital Input.
		/// </summary>
		SDI = 0,

		/// <summary>
		/// Safety Digital Output.
		/// </summary>
		SDO = 1,

		/// <summary>
		/// Remote Digital Input.
		/// </summary>
		RDI = 2,

		/// <summary>
		/// Remote Digital Output.
		/// </summary>
		RDO = 3,

		/// <summary>
		/// User Input.
		/// </summary>
		UI = 4,

		/// <summary>
		/// User Output.
		/// </summary>
		UO = 5,

		/// <summary>
		/// System Input.
		/// </summary>
		SI = 6,

		/// <summary>
		/// System Output.
		/// </summary>
		SO = 7,

		/// <summary>
		/// Weld Input.
		/// </summary>
		WI = 8,

		/// <summary>
		/// Weld Output.
		/// </summary>
		WO = 9,

		/// <summary>
		/// Wire Stick Input.
		/// </summary>
		WSI = 10,

		/// <summary>
		/// PMC Keep Relay.
		/// </summary>
		PMC_K = 11,

		/// <summary>
		/// PMC Internal Relay.
		/// </summary>
		PMC_R = 12,

		/// <summary>
		/// Analog Input.
		/// </summary>
		AI = 13,

		/// <summary>
		/// Analog Output.
		/// </summary>
		AO = 14,

		/// <summary>
		/// Group Input.
		/// </summary>
		GI = 15,

		/// <summary>
		/// Group Output.
		/// </summary>
		GO = 16,

		/// <summary>
		/// PMC Data Table.
		/// </summary>
		PMC_D = 17,
	}
}
