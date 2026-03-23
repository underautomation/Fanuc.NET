//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Identifies the type of data for which a comment can be read or written.
	/// </summary>
	public enum CommentType {

		/// <summary>
		/// Numeric register R[].
		/// </summary>
		Register = 0,

		/// <summary>
		/// Position register PR[].
		/// </summary>
		PositionRegister = 1,

		/// <summary>
		/// String register SR[].
		/// </summary>
		StringRegister = 2,

		/// <summary>
		/// Digital Input.
		/// </summary>
		DI = 3,

		/// <summary>
		/// Digital Output.
		/// </summary>
		DO = 4,

		/// <summary>
		/// Remote Input.
		/// </summary>
		RI = 5,

		/// <summary>
		/// Remote Output.
		/// </summary>
		RO = 6,

		/// <summary>
		/// User Input.
		/// </summary>
		UI = 7,

		/// <summary>
		/// User Output.
		/// </summary>
		UO = 8,

		/// <summary>
		/// System Input.
		/// </summary>
		SI = 9,

		/// <summary>
		/// System Output.
		/// </summary>
		SO = 10,

		/// <summary>
		/// Weld Input.
		/// </summary>
		WI = 11,

		/// <summary>
		/// Weld Output.
		/// </summary>
		WO = 12,

		/// <summary>
		/// Wire Stick Input.
		/// </summary>
		WSI = 13,

		/// <summary>
		/// Wire Stick Output.
		/// </summary>
		WSO = 14,

		/// <summary>
		/// Group Input.
		/// </summary>
		GI = 15,

		/// <summary>
		/// Group Output.
		/// </summary>
		GO = 16,

		/// <summary>
		/// Analog Input.
		/// </summary>
		AI = 17,

		/// <summary>
		/// Analog Output.
		/// </summary>
		AO = 18,

		/// <summary>
		/// Flag
		/// </summary>
		Flag = 19,
	}
}
