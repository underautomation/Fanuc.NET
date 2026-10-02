//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Cartesian velocity, acceleration and jerk limits, for the position (mm) and for the orientation (degrees)
	/// </summary>
	public class CartesianLimits {

		/// <summary>
		/// Creates limits with all values set to 0
		/// </summary>
		public CartesianLimits()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Creates limits with the given values
		/// </summary>
		/// <param name="linearVelocity">Linear velocity limit in mm/s</param>
		/// <param name="linearAcceleration">Linear acceleration limit in mm/s²</param>
		/// <param name="linearJerk">Linear jerk limit in mm/s³</param>
		/// <param name="angularVelocity">Angular velocity limit in deg/s</param>
		/// <param name="angularAcceleration">Angular acceleration limit in deg/s²</param>
		/// <param name="angularJerk">Angular jerk limit in deg/s³</param>
		public CartesianLimits(double linearVelocity, double linearAcceleration, double linearJerk, double angularVelocity, double angularAcceleration, double angularJerk)
		{
			// Source is hidden, a Source licence is needed to access internal code...
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
		/// Linear velocity limit in mm/s
		/// </summary>
		public double LinearVelocity { get; set; }

		/// <summary>
		/// Linear acceleration limit in mm/s²
		/// </summary>
		public double LinearAcceleration { get; set; }

		/// <summary>
		/// Linear jerk limit in mm/s³
		/// </summary>
		public double LinearJerk { get; set; }

		/// <summary>
		/// Angular velocity limit in deg/s
		/// </summary>
		public double AngularVelocity { get; set; }

		/// <summary>
		/// Angular acceleration limit in deg/s²
		/// </summary>
		public double AngularAcceleration { get; set; }

		/// <summary>
		/// Angular jerk limit in deg/s³
		/// </summary>
		public double AngularJerk { get; set; }
	}
}
