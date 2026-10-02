//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Robotics.IO;
using UnderAutomation.Robotics.Geometry;

namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Robot trajectory in joint or Cartesian format.
	/// A trajectory can be evaluated at any time between 0 and <see cref="UnderAutomation.Robotics.Motion.Trajectory.Duration"/>, and can carry I/O events.
	/// </summary>
	public class Trajectory {

		/// <summary>
		/// Maximum number of axes of a joint trajectory
		/// </summary>
		public const int MaxJointCount = 9;

		/// <summary>
		/// Maximum number of external axes of a Cartesian trajectory
		/// </summary>
		public const int MaxExternalAxisCount = 3;

		/// <summary>
		/// Adds a digital signal change at a given time of the trajectory
		/// </summary>
		/// <param name="time">Time from the start of the trajectory, in seconds (between 0 and <see cref="UnderAutomation.Robotics.Motion.Trajectory.Duration"/>)</param>
		/// <param name="signal">Signal to write</param>
		/// <param name="value">Value to write</param>
		public void AddIOEvent(double time, DigitalSignal signal, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Returns the joint position at the given time. The trajectory must be in joint format.
		/// </summary>
		/// <param name="time">Time from the start of the trajectory, in seconds. It is limited to the range [0, <see cref="UnderAutomation.Robotics.Motion.Trajectory.Duration"/>].</param>
		public JointValues GetJoints(double time)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the Cartesian pose at the given time. The trajectory must be in Cartesian format.
		/// </summary>
		/// <param name="time">Time from the start of the trajectory, in seconds. It is limited to the range [0, <see cref="UnderAutomation.Robotics.Motion.Trajectory.Duration"/>].</param>
		public CartesianPose GetCartesian(double time)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Samples the trajectory at a fixed period. The trajectory must be in joint format.
		/// </summary>
		/// <param name="cycleTime">Period between two samples, in seconds</param>
		/// <returns>Positions from time 0 to the end of the trajectory</returns>
		public JointValues[] SampleJoints(double cycleTime)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Samples the trajectory at a fixed period. The trajectory must be in Cartesian format.
		/// </summary>
		/// <param name="cycleTime">Period between two samples, in seconds</param>
		/// <returns>Poses from time 0 to the end of the trajectory</returns>
		public CartesianPose[] SampleCartesian(double cycleTime)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a joint trajectory from positions taken at a fixed period.
		/// When the trajectory is streamed to a robot at the same period, the positions are sent without any change.
		/// </summary>
		/// <param name="samples">Joint positions, one per period (up to <see cref="UnderAutomation.Robotics.Motion.Trajectory.MaxJointCount"/> axes)</param>
		/// <param name="cycleTime">Period between two positions, in seconds</param>
		public static Trajectory FromJointSamples(JointValues[] samples, double cycleTime)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a Cartesian trajectory from poses taken at a fixed period.
		/// When the trajectory is streamed to a robot at the same period, the poses are sent without any change.
		/// </summary>
		/// <param name="samples">Cartesian poses, one per period (up to <see cref="UnderAutomation.Robotics.Motion.Trajectory.MaxExternalAxisCount"/> external axes)</param>
		/// <param name="cycleTime">Period between two poses, in seconds</param>
		public static Trajectory FromCartesianSamples(CartesianPose[] samples, double cycleTime)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a joint trajectory that passes through positions at given times.
		/// The positions are joined by a smooth curve (cubic spline), and the robot is at rest at the first and the last position.
		/// The times are kept: use <see cref="UnderAutomation.Robotics.Motion.Trajectory.Check(UnderAutomation.Robotics.Motion.JointLimits,System.Double,System.Boolean)"/> to verify the limits, and <see cref="UnderAutomation.Robotics.Motion.Trajectory.Retime(UnderAutomation.Robotics.Motion.JointLimits,System.Double,System.Boolean)"/> to slow down the trajectory if needed.
		/// </summary>
		/// <param name="points">Joint positions (at least 2)</param>
		/// <param name="times">Time of each position in seconds, strictly increasing. The trajectory starts at the first time.</param>
		public static Trajectory FromTimedJoints(JointValues[] points, double[] times)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a Cartesian trajectory that passes through poses at given times.
		/// The poses are joined by a smooth curve (cubic spline), and the robot is at rest at the first and the last pose.
		/// The orientation is interpolated with quaternions, so it has no singularity.
		/// The times are kept: use <see cref="UnderAutomation.Robotics.Motion.Trajectory.CheckCartesian(UnderAutomation.Robotics.Motion.CartesianLimits,System.Double)"/> to verify the limits, and <see cref="UnderAutomation.Robotics.Motion.Trajectory.RetimeCartesian(UnderAutomation.Robotics.Motion.CartesianLimits,System.Double)"/> to slow down the trajectory if needed.
		/// </summary>
		/// <param name="points">Cartesian poses, at least 2</param>
		/// <param name="times">Time of each pose in seconds, strictly increasing. The trajectory starts at the first time.</param>
		public static Trajectory FromTimedCartesian(CartesianPose[] points, double[] times)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Checks the velocity, acceleration and jerk of each axis as a robot computes them from a stream of positions: positions sampled at the communication cycle,
		/// differences between consecutive positions divided by the cycle time, and positions before the first one equal to the first one.
		/// The trajectory must be in joint format.
		/// </summary>
		/// <param name="limits">Limits of each axis. Axes with a limit of 0 are not checked.</param>
		/// <param name="cycleTime">Communication cycle of the robot in seconds</param>
		/// <param name="singlePrecision">True to round the positions to single precision first, when the robot receives them in single precision</param>
		public TrajectoryReport Check(JointLimits limits, double cycleTime, bool singlePrecision)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Checks the linear and angular velocity, acceleration and jerk, computed from positions sampled at the communication cycle.
		/// The trajectory must be in Cartesian format. The joint limits of the robot cannot be checked from Cartesian positions.
		/// </summary>
		/// <param name="limits">Cartesian limits. Values of 0 are not checked.</param>
		/// <param name="cycleTime">Communication cycle of the robot in seconds</param>
		public CartesianTrajectoryReport CheckCartesian(CartesianLimits limits, double cycleTime)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the same path played slower so that the joint limits are respected (see <see cref="UnderAutomation.Robotics.Motion.Trajectory.Check(UnderAutomation.Robotics.Motion.JointLimits,System.Double,System.Boolean)"/>).
		/// The positions are the same, only the time is stretched. Returns this trajectory when it is already valid.
		/// </summary>
		/// <param name="limits">Limits of each axis</param>
		/// <param name="cycleTime">Communication cycle of the robot in seconds</param>
		/// <param name="singlePrecision">True to check the positions rounded to single precision, when the robot receives them in single precision</param>
		public Trajectory Retime(JointLimits limits, double cycleTime, bool singlePrecision = false)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the same path played slower so that the Cartesian limits are respected (see <see cref="UnderAutomation.Robotics.Motion.Trajectory.CheckCartesian(UnderAutomation.Robotics.Motion.CartesianLimits,System.Double)"/>).
		/// The positions are the same, only the time is stretched. Returns this trajectory when it is already valid.
		/// </summary>
		/// <param name="limits">Cartesian limits</param>
		/// <param name="cycleTime">Communication cycle of the robot in seconds</param>
		public Trajectory RetimeCartesian(CartesianLimits limits, double cycleTime)
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
		/// Format of the positions of this trajectory
		/// </summary>
		public PositionFormat Format { get; }

		/// <summary>
		/// Duration of the trajectory in seconds
		/// </summary>
		public double Duration { get; }

		/// <summary>
		/// Period between two samples in seconds, when the trajectory was created from samples. 0 otherwise.
		/// </summary>
		public double CycleTime { get; }

		/// <summary>
		/// Indicates if the velocity and the acceleration are zero at the start of the trajectory
		/// </summary>
		public bool StartsAtRest { get; }

		/// <summary>
		/// Indicates if the velocity and the acceleration are zero at the end of the trajectory
		/// </summary>
		public bool EndsAtRest { get; }

		/// <summary>
		/// I/O events of this trajectory, sorted by time
		/// </summary>
		public IOEvent[] IOEvents { get; }
	}
}
