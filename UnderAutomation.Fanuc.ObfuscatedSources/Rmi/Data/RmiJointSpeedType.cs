//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Rmi.Data {
	/// <summary>
	/// Speed type for joint motion commands.
	/// </summary>
	public enum RmiJointSpeedType {

		/// <summary>
		/// Joint speed as a percentage of maximum (1–100 %).
		/// </summary>
		Percent = 0,

		/// <summary>
		/// Duration-based speed (0.1-second units).
		/// </summary>
		Time = 1,

		/// <summary>
		/// Duration-based speed in milliseconds.
		/// </summary>
		MSec = 2,
	}
}
