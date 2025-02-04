//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Telnet {
	/// <summary>
	/// Enumeration of TP (Teach Pendant) coordinate systems.
	/// </summary>
	public enum TpCoordinates {

		/// <summary>
		/// Unknown coordinate system.
		/// </summary>
		Unknown = -1,

		/// <summary>
		/// Tool coordinate system.
		/// </summary>
		Tool = 0,

		/// <summary>
		/// User coordinate system.
		/// </summary>
		User = 1,

		/// <summary>
		/// Joint coordinate system.
		/// </summary>
		Joint = 2,

		/// <summary>
		/// Jog frame coordinate system.
		/// </summary>
		JogFrame = 3,

		/// <summary>
		/// World coordinate system.
		/// </summary>
		World = 4,
	}
}
