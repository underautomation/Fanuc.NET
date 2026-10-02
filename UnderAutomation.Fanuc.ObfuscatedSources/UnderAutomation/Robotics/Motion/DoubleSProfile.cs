//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// One-dimensional motion profile with bounded velocity, acceleration and jerk (7 phases, "double S" profile).
	/// The acceleration is zero at the start and at the end. Start and end velocities can be different from zero.
	/// </summary>
	public class DoubleSProfile {

		/// <summary>
		/// Computes the fastest profile from a start position to an end position with the given limits
		/// </summary>
		/// <param name="startPosition">Start position</param>
		/// <param name="endPosition">End position</param>
		/// <param name="startVelocity">Velocity at the start</param>
		/// <param name="endVelocity">Velocity at the end</param>
		/// <param name="maxVelocity">Velocity limit (greater than 0)</param>
		/// <param name="maxAcceleration">Acceleration limit (greater than 0)</param>
		/// <param name="maxJerk">Jerk limit (greater than 0)</param>
		public DoubleSProfile(double startPosition, double endPosition, double startVelocity, double endVelocity, double maxVelocity, double maxAcceleration, double maxJerk)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Position at the given time (limited to [0, <see cref="UnderAutomation.Robotics.Motion.DoubleSProfile.Duration"/>])
		/// </summary>
		/// <param name="time">Time in seconds</param>
		public double GetPosition(double time)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Velocity at the given time (limited to [0, <see cref="UnderAutomation.Robotics.Motion.DoubleSProfile.Duration"/>])
		/// </summary>
		/// <param name="time">Time in seconds</param>
		public double GetVelocity(double time)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Acceleration at the given time (limited to [0, <see cref="UnderAutomation.Robotics.Motion.DoubleSProfile.Duration"/>])
		/// </summary>
		/// <param name="time">Time in seconds</param>
		public double GetAcceleration(double time)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Jerk at the given time (limited to [0, <see cref="UnderAutomation.Robotics.Motion.DoubleSProfile.Duration"/>])
		/// </summary>
		/// <param name="time">Time in seconds</param>
		public double GetJerk(double time)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the same motion slowed down to last the given duration. The velocity is divided by k, the acceleration by k² and the jerk by k³,
		/// where k is the ratio of the durations, so the limits are still respected. Only for profiles that start and end at rest.
		/// </summary>
		/// <param name="duration">New duration in seconds, not lower than <see cref="UnderAutomation.Robotics.Motion.DoubleSProfile.Duration"/></param>
		public DoubleSProfile StretchTo(double duration)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Start position
		/// </summary>
		public double StartPosition { get; }

		/// <summary>
		/// End position
		/// </summary>
		public double EndPosition { get; }

		/// <summary>
		/// Velocity at the start
		/// </summary>
		public double StartVelocity { get; }

		/// <summary>
		/// Velocity at the end
		/// </summary>
		public double EndVelocity { get; }

		/// <summary>
		/// Velocity limit used to compute the profile
		/// </summary>
		public double MaxVelocity { get; }

		/// <summary>
		/// Acceleration limit used to compute the profile
		/// </summary>
		public double MaxAcceleration { get; }

		/// <summary>
		/// Jerk limit used to compute the profile
		/// </summary>
		public double MaxJerk { get; }

		/// <summary>
		/// Duration of the profile in seconds
		/// </summary>
		public double Duration { get; }

		/// <summary>
		/// Duration of the acceleration phase in seconds
		/// </summary>
		public double AccelerationTime { get; }

		/// <summary>
		/// Duration of the constant velocity phase in seconds
		/// </summary>
		public double ConstantVelocityTime { get; }

		/// <summary>
		/// Duration of the deceleration phase in seconds
		/// </summary>
		public double DecelerationTime { get; }

		/// <summary>
		/// Highest velocity reached (absolute value)
		/// </summary>
		public double PeakVelocity { get; }
	}
}
