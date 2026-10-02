//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Format of the positions of a trajectory
	/// </summary>
	public enum PositionFormat {

		/// <summary>
		/// Joint positions (up to 9 axes), in degrees (mm for linear axes)
		/// </summary>
		Joint = 0,

		/// <summary>
		/// Cartesian positions X, Y, Z in mm with an orientation, plus up to 3 external axes
		/// </summary>
		Cartesian = 1,
	}
}
