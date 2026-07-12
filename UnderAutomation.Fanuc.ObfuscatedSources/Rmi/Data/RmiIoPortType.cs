//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// IO port type for generic read/write operations.
	/// </summary>
	public enum RmiIoPortType {

		/// <summary>
		/// Digital Input.
		/// </summary>
		DI = 0,

		/// <summary>
		/// Digital Output.
		/// </summary>
		DO = 1,

		/// <summary>
		/// Analog Input.
		/// </summary>
		AI = 2,

		/// <summary>
		/// Analog Output.
		/// </summary>
		AO = 3,

		/// <summary>
		/// Group Output.
		/// </summary>
		GO = 4,

		/// <summary>
		/// Robot Output.
		/// </summary>
		RO = 5,

		/// <summary>
		/// Internal flag register.
		/// </summary>
		FLAG = 6,

		/// <summary>
		/// Robot Input.
		/// </summary>
		RI = 7,

		/// <summary>
		/// User Interface Input.
		/// </summary>
		UI = 8,

		/// <summary>
		/// User Interface Output.
		/// </summary>
		UO = 9,
	}
}
