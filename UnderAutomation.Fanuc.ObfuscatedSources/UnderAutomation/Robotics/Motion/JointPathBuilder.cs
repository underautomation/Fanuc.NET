//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Robotics.Geometry;
using UnderAutomation.Robotics.IO;

namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Builds a joint trajectory from a sequence of joint motions.
	/// Create it with <see cref="UnderAutomation.Robotics.Motion.MotionPlanner.CreateJointPath(UnderAutomation.Robotics.Geometry.JointValues)"/>.
	/// </summary>
	public class JointPathBuilder {

		/// <summary>
		/// Adds a joint motion: all axes move on a straight line in joint space and arrive at the same time
		/// </summary>
		/// <param name="target">Target joint position</param>
		/// <param name="speedPercent">Speed in percent of the velocity limits (greater than 0, up to 100)</param>
		/// <param name="termination">Termination: stop or overlap</param>
		/// <param name="accelerationPercent">Acceleration and jerk in percent of the limits (greater than 0, up to 100)</param>
		public JointPathBuilder MoveJoint(JointValues target, double speedPercent, Termination termination, double accelerationPercent = 100)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds a joint motion that lasts a given time. The motion takes more time when the limits do not allow this duration.
		/// </summary>
		/// <param name="target">Target joint position</param>
		/// <param name="duration">Duration in seconds</param>
		/// <param name="termination">Termination: stop or overlap</param>
		public JointPathBuilder MoveJointTime(JointValues target, double duration, Termination termination)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds a smooth joint motion that passes through a list of positions (cubic spline) and ends at the last one.
		/// The speed changes along the path so that the velocity, acceleration and jerk of each axis stay within the limits.
		/// The points must describe a smooth path: close or noisy points give high curvatures and a slow motion.
		/// </summary>
		/// <param name="points">Positions to pass through. A first position equal to the current position is ignored.</param>
		/// <param name="speedPercent">Speed in percent of the velocity limits (greater than 0, up to 100)</param>
		/// <param name="termination">Termination at the last position: stop or overlap</param>
		/// <param name="accelerationPercent">Acceleration and jerk in percent of the limits (greater than 0, up to 100)</param>
		public JointPathBuilder MoveJointSpline(JointValues[] points, double speedPercent, Termination termination, double accelerationPercent = 100)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Keeps the current position during a given time
		/// </summary>
		/// <param name="duration">Duration in seconds</param>
		public JointPathBuilder Wait(double duration)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a digital signal when the previous motion ends
		/// </summary>
		/// <param name="signal">Signal to write</param>
		/// <param name="value">Value to write</param>
		public JointPathBuilder SetIO(DigitalSignal signal, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates the trajectory
		/// </summary>
		public Trajectory Build()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Position at the end of the motions added so far
		/// </summary>
		public JointValues EndPosition { get; }
	}
}
