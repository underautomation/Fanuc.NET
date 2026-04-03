//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Cgtp {
	/// <summary>
	/// Type of I/O port on the controller.
	/// </summary>
	public enum CgtpIoPortType {

		/// <summary>
		/// Digital input.
		/// </summary>
		DI = 1,

		/// <summary>
		/// Digital output.
		/// </summary>
		DO = 2,

		/// <summary>
		/// Analog input.
		/// </summary>
		AI = 3,

		/// <summary>
		/// Analog output.
		/// </summary>
		AO = 4,

		/// <summary>
		/// Robot input.
		/// </summary>
		RI = 8,

		/// <summary>
		/// Robot output.
		/// </summary>
		RO = 9,

		/// <summary>
		/// Group input.
		/// </summary>
		GI = 18,

		/// <summary>
		/// Group output.
		/// </summary>
		GO = 19,

		/// <summary>
		/// Flag.
		/// </summary>
		Flag = 35,
	}
}
