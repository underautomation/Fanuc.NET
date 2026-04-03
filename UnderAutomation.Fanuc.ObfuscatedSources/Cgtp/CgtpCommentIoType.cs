//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Cgtp {
	/// <summary>
	/// Type of I/O pair whose comments can be read via CGTP.
	/// </summary>
	public enum CgtpCommentIoType {

		/// <summary>
		/// Robot I/O (RI/RO).
		/// </summary>
		RobotIO = 32,

		/// <summary>
		/// Digital I/O (DI/DO).
		/// </summary>
		DigitalIO = 33,

		/// <summary>
		/// Group I/O (GI/GO).
		/// </summary>
		GroupIO = 34,

		/// <summary>
		/// Analog I/O (AI/AO).
		/// </summary>
		AnalogIO = 35,
	}
}
