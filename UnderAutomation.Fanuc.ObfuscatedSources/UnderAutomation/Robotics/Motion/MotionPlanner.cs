//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Robotics.Geometry;

namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Creates trajectories from joint motions, linear and circular motions, splines and shapes,
	/// with velocity, acceleration and jerk limits.
	/// </summary>
	public class MotionPlanner {

		/// <summary>
		/// Creates a planner
		/// </summary>
		/// <param name="jointLimits">Limits for joint motions (can be null if only Cartesian motions are planned)</param>
		/// <param name="cartesianLimits">Limits for Cartesian motions (can be null if only joint motions are planned)</param>
		public MotionPlanner(JointLimits jointLimits, CartesianLimits cartesianLimits)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Starts a joint path
		/// </summary>
		/// <param name="start">Start position, for example the current position of the robot (up to <see cref="UnderAutomation.Robotics.Motion.Trajectory.MaxJointCount"/> axes)</param>
		public JointPathBuilder CreateJointPath(JointValues start)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Starts a Cartesian path
		/// </summary>
		/// <param name="start">Start pose of the flange in the world frame, for example the current pose of the robot.
		///             It is converted with <see cref="UnderAutomation.Robotics.Motion.MotionPlanner.ToolFrame"/> and <see cref="UnderAutomation.Robotics.Motion.MotionPlanner.UserFrame"/>.</param>
		public CartesianPathBuilder CreateCartesianPath(CartesianPose start)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Limits for joint motions. 100% speed uses the velocity limits of this object.
		/// The limits of axes 7 to 9 are also used for the external axes of Cartesian motions.
		/// </summary>
		public JointLimits JointLimits { get; set; }

		/// <summary>
		/// Limits for Cartesian motions
		/// </summary>
		public CartesianLimits CartesianLimits { get; set; }

		/// <summary>
		/// Tool frame, relative to the flange. When it is set, the targets of Cartesian motions are poses of this tool,
		/// and the trajectory gives the flange poses. Null when the targets are flange poses.
		/// </summary>
		public CartesianPose ToolFrame { get; set; }

		/// <summary>
		/// User frame, relative to the world frame. When it is set, the targets of Cartesian motions are expressed in this frame,
		/// and the trajectory gives poses in the world frame. Null when the targets are in the world frame.
		/// </summary>
		public CartesianPose UserFrame { get; set; }
	}
}
