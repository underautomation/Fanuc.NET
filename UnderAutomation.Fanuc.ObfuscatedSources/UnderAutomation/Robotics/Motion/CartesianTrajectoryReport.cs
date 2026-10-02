//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Result of the check of a Cartesian trajectory against Cartesian velocity, acceleration and jerk limits
	/// </summary>
	public class CartesianTrajectoryReport {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// True when no limit is exceeded
		/// </summary>
		public bool IsValid { get; }

		/// <summary>
		/// Number of samples checked
		/// </summary>
		public int SampleCount { get; }

		/// <summary>
		/// Period used for the check, in seconds
		/// </summary>
		public double CycleTime { get; }

		/// <summary>
		/// Highest linear velocity in mm/s
		/// </summary>
		public double MaxLinearVelocity { get; }

		/// <summary>
		/// Highest linear acceleration in mm/s²
		/// </summary>
		public double MaxLinearAcceleration { get; }

		/// <summary>
		/// Highest linear jerk in mm/s³
		/// </summary>
		public double MaxLinearJerk { get; }

		/// <summary>
		/// Highest angular velocity in deg/s
		/// </summary>
		public double MaxAngularVelocity { get; }

		/// <summary>
		/// Highest angular acceleration in deg/s²
		/// </summary>
		public double MaxAngularAcceleration { get; }

		/// <summary>
		/// Highest angular jerk in deg/s³
		/// </summary>
		public double MaxAngularJerk { get; }

		/// <summary>
		/// Total number of values that exceed a limit
		/// </summary>
		public int ViolationCount { get; }

		/// <summary>
		/// First violations (at most 100). Axis 1 is the position, axis 2 the orientation.
		/// </summary>
		public TrajectoryViolation[] Violations { get; }
	}
}
