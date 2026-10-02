//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Robotics.Motion;

namespace UnderAutomation.Fanuc.StreamMotion.Data {
	/// <summary>
	/// Allowable velocity, acceleration and jerk limits of the robot axes, read from the robot.
	/// The robot stops with an alarm when a position sent to it exceeds these limits.
	/// </summary>
	public class StreamMotionLimits {

		/// <summary>
		/// Returns the table of limits of one axis
		/// </summary>
		/// <param name="axis">Axis number (1 to 9)</param>
		/// <param name="type">Type of limit</param>
		public LimitTable GetTable(int axis, LimitType type)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Computes the limits of all axes for a given flange speed and payload, as the robot does when $STMO_GRP[1].$LMT_MODE is 0.
		/// </summary>
		/// <param name="flangeSpeed">Peak speed of the flange center, in mm/s</param>
		/// <param name="payload">Payload mass, in kg</param>
		/// <param name="maxPayload">Maximum payload of the robot, in kg</param>
		public JointLimits ComputeLimits(double flangeSpeed, double payload, double maxPayload)
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
		/// Number of axes of the robot (axes with limits)
		/// </summary>
		public int AxisCount { get; }

		/// <summary>
		/// Maximum speed of the flange center (Vmax, system variable $STMO_GRP[1].$MAX_SPD), in mm/s
		/// </summary>
		public double MaxSpeed { get; }

		/// <summary>
		/// Time interval of the intermediate check of the limits, in seconds
		/// </summary>
		public double IntermediateCheckTime { get; }

		/// <summary>
		/// Reference limits of each axis: values with the maximum payload at the maximum speed.
		/// They are equal to the system variables $STMO_GRP[1].$JNT_VEL_LIM, $JNT_ACC_LIM and $JNT_JRK_LIM, and they are always safe.
		/// </summary>
		public JointLimits ReferenceLimits { get; }
	}
}
