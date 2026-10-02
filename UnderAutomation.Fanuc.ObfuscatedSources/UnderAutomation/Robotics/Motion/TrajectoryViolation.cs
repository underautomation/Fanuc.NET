//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Limit exceeded by a trajectory at one sample
	/// </summary>
	public class TrajectoryViolation {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Index of the sample
		/// </summary>
		public int Index { get; }

		/// <summary>
		/// Time of the sample in seconds
		/// </summary>
		public double Time { get; }

		/// <summary>
		/// Axis number (1 to 9). For a Cartesian check: 1 for the position, 2 for the orientation.
		/// </summary>
		public int Axis { get; }

		/// <summary>
		/// Type of limit exceeded
		/// </summary>
		public LimitType Type { get; }

		/// <summary>
		/// Value reached (absolute value)
		/// </summary>
		public double Value { get; }

		/// <summary>
		/// Limit
		/// </summary>
		public double Limit { get; }
	}
}
