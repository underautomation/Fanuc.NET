//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Cgtp {
	/// <summary>
	/// Type of element whose comment can be read or written via CGTP.
	/// </summary>
	public enum CgtpCommentType {

		/// <summary>
		/// Numeric register (R[]).
		/// </summary>
		NumericRegister = 1,

		/// <summary>
		/// Position register (PR[]).
		/// </summary>
		PositionRegister = 3,

		/// <summary>
		/// User alarm.
		/// </summary>
		UserAlarm = 4,

		/// <summary>
		/// Robot input.
		/// </summary>
		RI = 6,

		/// <summary>
		/// Robot output.
		/// </summary>
		RO = 7,

		/// <summary>
		/// Digital input.
		/// </summary>
		DI = 8,

		/// <summary>
		/// Digital output.
		/// </summary>
		DO = 9,

		/// <summary>
		/// Group input.
		/// </summary>
		GI = 10,

		/// <summary>
		/// Group output.
		/// </summary>
		GO = 11,

		/// <summary>
		/// Analog input.
		/// </summary>
		AI = 12,

		/// <summary>
		/// Analog output.
		/// </summary>
		AO = 13,

		/// <summary>
		/// String register (SR[]).
		/// </summary>
		StringRegister = 14,

		/// <summary>
		/// Flag (F[]).
		/// </summary>
		Flag = 19,
	}
}
