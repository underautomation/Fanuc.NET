//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Velocity, acceleration and jerk limits of the 9 axes of a robot.
	/// Units are degrees (mm for linear axes) per second, per second squared and per second cubed.
	/// A limit of 0 means that the axis is not present or not limited.
	/// </summary>
	public class JointLimits {

		/// <summary>
		/// Number of axes handled by this class
		/// </summary>
		public const int AxisCount = 9;

		/// <summary>
		/// Creates limits with all values set to 0
		/// </summary>
		public JointLimits()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates limits from arrays of values. Arrays can contain less than 9 values, missing values are set to 0.
		/// </summary>
		/// <param name="velocity">Velocity limit of each axis</param>
		/// <param name="acceleration">Acceleration limit of each axis</param>
		/// <param name="jerk">Jerk limit of each axis</param>
		public JointLimits(double[] velocity, double[] acceleration, double[] jerk)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns a copy of these limits where each value is multiplied by the given factors
		/// </summary>
		/// <param name="velocityFactor">Factor applied to velocity limits</param>
		/// <param name="accelerationFactor">Factor applied to acceleration limits</param>
		/// <param name="jerkFactor">Factor applied to jerk limits</param>
		public JointLimits Scale(double velocityFactor, double accelerationFactor, double jerkFactor)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Velocity limit of each axis (9 values)
		/// </summary>
		public double[] Velocity { get; }

		/// <summary>
		/// Acceleration limit of each axis (9 values)
		/// </summary>
		public double[] Acceleration { get; }

		/// <summary>
		/// Jerk limit of each axis (9 values)
		/// </summary>
		public double[] Jerk { get; }
	}
}
