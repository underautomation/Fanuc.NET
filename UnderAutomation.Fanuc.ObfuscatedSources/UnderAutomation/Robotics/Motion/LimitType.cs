//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Type of limit of a robot axis
	/// </summary>
	public enum LimitType {

		/// <summary>
		/// Velocity limit, in deg/s (mm/s for linear axes)
		/// </summary>
		Velocity = 0,

		/// <summary>
		/// Acceleration limit, in deg/s² (mm/s² for linear axes)
		/// </summary>
		Acceleration = 1,

		/// <summary>
		/// Jerk limit, in deg/s³ (mm/s³ for linear axes)
		/// </summary>
		Jerk = 2,
	}
}
