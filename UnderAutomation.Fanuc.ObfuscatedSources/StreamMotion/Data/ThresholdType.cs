//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace StreamMotion.Data {
	/// <summary>
	/// Threshold types for request packets
	/// </summary>
	public enum ThresholdType : uint {

		/// <summary>
		/// Velocity threshold (deg/s)
		/// </summary>
		Velocity = 0,

		/// <summary>
		/// Acceleration threshold (deg/s²)
		/// </summary>
		Acceleration = 1,

		/// <summary>
		/// Jerk threshold (deg/s³)
		/// </summary>
		Jerk = 2,
	}
}
