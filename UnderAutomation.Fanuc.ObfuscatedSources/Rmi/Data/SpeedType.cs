//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Speed type selector for motion commands.
	/// </summary>
	public enum SpeedType {

		/// <summary>
		/// Linear speed in millimeters per second.
		/// </summary>
		MmSec = 0,

		/// <summary>
		/// Linear speed in inches per minute.
		/// </summary>
		InchMin = 1,

		/// <summary>
		/// Duration-based speed (0.1 seconds unit for Linear/Circular, milliseconds for Joint).
		/// </summary>
		Time = 2,

		/// <summary>
		/// Joint speed as percentage of maximum.
		/// </summary>
		Percent = 3,
	}
}
