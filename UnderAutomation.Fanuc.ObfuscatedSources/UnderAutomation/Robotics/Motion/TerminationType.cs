//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Type of termination of a motion
	/// </summary>
	public enum TerminationType {

		/// <summary>
		/// The robot stops at the target position
		/// </summary>
		Stop = 0,

		/// <summary>
		/// The next motion starts during the deceleration of this one. The corner is rounded, more at high speed.
		/// Between linear and circular motions, the corner is replaced by a smooth curve that starts where the robot would start to decelerate (overlap of 100%), or closer to the target.
		/// </summary>
		Overlap = 1,

		/// <summary>
		/// Corner region: the corner is replaced by a smooth curve that starts and ends at a given distance from the target position.
		/// The speed stays constant in the curve, and is reduced when its curvature needs it. Only between Cartesian motions.
		/// </summary>
		Corner = 2,
	}
}
