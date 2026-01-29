//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Data style for motion commands
	/// </summary>
	public enum DataStyle : byte {

		/// <summary>
		/// Cartesian coordinate system (X, Y, Z, W, P, R)
		/// </summary>
		Cartesian = 0,

		/// <summary>
		/// Joint coordinate system (J1-J9)
		/// </summary>
		Joint = 1,
	}
}
