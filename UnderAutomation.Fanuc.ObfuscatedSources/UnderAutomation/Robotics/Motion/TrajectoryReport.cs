//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Result of the check of a joint trajectory against velocity, acceleration and jerk limits
	/// </summary>
	public class TrajectoryReport {


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
		/// Highest velocity of each axis (9 values)
		/// </summary>
		public double[] MaxVelocity { get; }

		/// <summary>
		/// Highest acceleration of each axis (9 values)
		/// </summary>
		public double[] MaxAcceleration { get; }

		/// <summary>
		/// Highest jerk of each axis (9 values)
		/// </summary>
		public double[] MaxJerk { get; }

		/// <summary>
		/// Total number of values that exceed a limit
		/// </summary>
		public int ViolationCount { get; }

		/// <summary>
		/// First violations (at most 100)
		/// </summary>
		public TrajectoryViolation[] Violations { get; }
	}
}
