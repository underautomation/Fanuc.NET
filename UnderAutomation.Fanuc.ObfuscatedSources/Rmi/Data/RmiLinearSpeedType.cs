//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Speed type for linear and circular motion commands.
	/// </summary>
	public enum RmiLinearSpeedType {

		/// <summary>
		/// Linear speed in millimeters per second.
		/// </summary>
		MmSec = 0,

		/// <summary>
		/// Linear speed in inches per minute.
		/// </summary>
		InchMin = 1,

		/// <summary>
		/// Duration-based speed (0.1-second units).
		/// </summary>
		Time = 2,

		/// <summary>
		/// Duration-based speed in milliseconds.
		/// </summary>
		MSec = 3,
	}
}
