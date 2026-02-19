//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Snpx.Internal {
	/// <summary>
	/// Defines segment selector codes for SNPX memory access operations.
	/// </summary>
	public enum SegmentSelector : byte {

		/// <summary>
		/// Bit-level input segment.
		/// </summary>
		BIT_I = 70,

		/// <summary>
		/// Bit-level output segment.
		/// </summary>
		BIT_Q = 72,

		/// <summary>
		/// Bit-level T segment.
		/// </summary>
		BIT_T = 74,

		/// <summary>
		/// Bit-level M segment.
		/// </summary>
		BIT_M = 76,

		/// <summary>
		/// Bit-level SA segment.
		/// </summary>
		BIT_SA = 78,

		/// <summary>
		/// Bit-level SB segment.
		/// </summary>
		BIT_SB = 80,

		/// <summary>
		/// Bit-level SC segment.
		/// </summary>
		BIT_SC = 82,

		/// <summary>
		/// Bit-level S segment.
		/// </summary>
		BIT_S = 84,

		/// <summary>
		/// Bit-level G segment.
		/// </summary>
		BIT_G = 86,

		/// <summary>
		/// Byte-level input segment.
		/// </summary>
		BYTE_I = 16,

		/// <summary>
		/// Byte-level output segment.
		/// </summary>
		BYTE_Q = 18,

		/// <summary>
		/// Byte-level T segment.
		/// </summary>
		BYTE_T = 20,

		/// <summary>
		/// Byte-level M segment.
		/// </summary>
		BYTE_M = 22,

		/// <summary>
		/// Byte-level SA segment.
		/// </summary>
		BYTE_SA = 26,

		/// <summary>
		/// Byte-level SB segment.
		/// </summary>
		BYTE_SB = 28,

		/// <summary>
		/// Byte-level SC segment.
		/// </summary>
		BYTE_SC = 30,

		/// <summary>
		/// Byte-level G segment.
		/// </summary>
		BYTE_G = 56,

		/// <summary>
		/// Word-level R segment for register access.
		/// </summary>
		WORD_R = 8,

		/// <summary>
		/// Word-level AI segment for analog input.
		/// </summary>
		WORD_AI = 10,

		/// <summary>
		/// Word-level AQ segment for analog output.
		/// </summary>
		WORD_AQ = 12,

		/// <summary>
		/// Selector used during connection initialization.
		/// </summary>
		INIT = 1,
	}
}
