//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Fanuc.Common;
using UnderAutomation.Robotics.Geometry;
using UnderAutomation.Robotics.Motion;
using UnderAutomation.Fanuc.StreamMotion.Data;
using UnderAutomation.Robotics.IO;

namespace UnderAutomation.Fanuc.Motion {
	/// <summary>
	/// Conversions between the FANUC types (positions, FINE/CNT/CR terminations, I/O types) and the types of the motion planner
	/// of namespace UnderAutomation.Robotics.Motion.
	/// </summary>
	public static class FanucMotion {

		/// <summary>
		/// Converts a FANUC position to a pose. The extended axes E1, E2 and E3 are copied when the position is an <see cref="UnderAutomation.Fanuc.Common.ExtendedCartesianPosition"/>.
		/// </summary>
		/// <param name="position">Position X, Y, Z, W, P, R</param>
		public static CartesianPose ToCartesianPose(XYZWPRPosition position)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a pose to a FANUC position with extended axes (0 when the pose has no external axes).
		/// </summary>
		/// <param name="pose">Pose to convert</param>
		/// <param name="reference">Position used to choose the W, P, R angles: the angles closest to the ones of this position are returned,
		///             so that a sequence of positions stays continuous. When it is null, W and R are between -180 and 180 degrees, and P between -90 and 90 degrees.</param>
		public static ExtendedCartesianPosition ToExtendedCartesianPosition(CartesianPose pose, XYZWPRPosition reference)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts a FANUC joint position (J1 to J9) to joint values
		/// </summary>
		/// <param name="position">Joint position</param>
		public static JointValues ToJointValues(JointsPosition position)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Converts joint values to a FANUC joint position. Missing axes are 0.
		/// </summary>
		/// <param name="values">Joint values (up to 9 axes)</param>
		public static JointsPosition ToJointsPosition(JointValues values)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// FINE termination: the robot stops at the target position
		/// </summary>
		public static Termination Fine()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// CNT termination: the next motion starts during the deceleration of this one
		/// </summary>
		/// <param name="value">From 0 to 100: part of the deceleration during which both motions are combined. 100 gives the smoothest motion.</param>
		public static Termination Cnt(int value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// CR termination (corner region): the corner is replaced by a smooth curve at constant speed. Only between Cartesian motions.
		/// </summary>
		/// <param name="distance">Distance from the target position where the curve starts and ends, in mm. It is limited to half of the length of each motion.</param>
		public static Termination Cr(double distance)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Returns the digital signal of an I/O, to write it during a trajectory (for example DO[5])
		/// </summary>
		/// <param name="type">I/O type</param>
		/// <param name="index">I/O index (starts at 1)</param>
		public static DigitalSignal Signal(IOType type, int index)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a Cartesian trajectory from FANUC positions taken at a fixed period.
		/// The W, P, R angles are kept without any change, and the extended axes are used when the positions are <see cref="UnderAutomation.Fanuc.Common.ExtendedCartesianPosition"/>.
		/// </summary>
		/// <param name="samples">Positions (flange center in the world frame for Stream Motion), one per period</param>
		/// <param name="cycleTime">Period between two positions, in seconds</param>
		public static Trajectory FromCartesianSamples(XYZWPRPosition[] samples, double cycleTime)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Samples a Cartesian trajectory at a fixed period and returns FANUC positions. The W, P, R angles stay continuous from one position to the next.
		/// </summary>
		/// <param name="trajectory">Trajectory in Cartesian format</param>
		/// <param name="cycleTime">Period between two samples, in seconds</param>
		/// <returns>Positions from time 0 to the end of the trajectory</returns>
		public static ExtendedCartesianPosition[] SampleCartesian(Trajectory trajectory, double cycleTime)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Convention of the W, P, R angles of FANUC positions: rotation W around the fixed X axis, then P around the fixed Y axis, then R around the fixed Z axis
		/// </summary>
		public static EulerConvention WprConvention { get; }
	}
}
