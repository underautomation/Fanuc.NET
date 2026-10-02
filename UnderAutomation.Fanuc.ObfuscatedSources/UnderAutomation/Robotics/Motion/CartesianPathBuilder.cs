//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Robotics.Geometry;
using UnderAutomation.Robotics.IO;

namespace UnderAutomation.Robotics.Motion {
	/// <summary>
	/// Builds a Cartesian trajectory from a sequence of linear and circular motions, splines and shapes.
	/// Create it with <see cref="UnderAutomation.Robotics.Motion.MotionPlanner.CreateCartesianPath(UnderAutomation.Robotics.Geometry.CartesianPose)"/>. Targets are poses of the tool of the planner, in its user frame.
	/// </summary>
	public class CartesianPathBuilder {

		/// <summary>
		/// Adds a linear motion: the tool moves on a straight line and its orientation turns on the shortest way.
		/// </summary>
		/// <param name="target">Target pose. When it has no external axes, the external axes keep their current values.</param>
		/// <param name="speed">Speed in mm/s</param>
		/// <param name="termination">Termination: stop, overlap or corner</param>
		/// <param name="accelerationPercent">Acceleration and jerk in percent of the limits (greater than 0, up to 100)</param>
		public CartesianPathBuilder MoveLinear(CartesianPose target, double speed, Termination termination, double accelerationPercent = 100)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds a linear motion that lasts a given time. The motion takes more time when the limits do not allow this duration.
		/// </summary>
		/// <param name="target">Target pose. When it has no external axes, the external axes keep their current values.</param>
		/// <param name="duration">Duration in seconds</param>
		/// <param name="termination">Termination: stop or overlap</param>
		public CartesianPathBuilder MoveLinearTime(CartesianPose target, double duration, Termination termination)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds a circular motion: the tool moves on the circle arc that passes through the via point and ends at the target.
		/// The orientation turns from the current orientation to the orientation of the target (the orientation of the via point is not used).
		/// </summary>
		/// <param name="via">Point on the arc</param>
		/// <param name="target">Target pose. When it has no external axes, the external axes keep their current values.</param>
		/// <param name="speed">Speed in mm/s</param>
		/// <param name="termination">Termination: stop, overlap or corner</param>
		/// <param name="accelerationPercent">Acceleration and jerk in percent of the limits (greater than 0, up to 100)</param>
		public CartesianPathBuilder MoveCircular(CartesianPose via, CartesianPose target, double speed, Termination termination, double accelerationPercent = 100)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds a smooth motion that passes through a list of positions (cubic spline) and ends at the last one.
		/// The orientation passes through the orientation of each position. The speed is constant along the path,
		/// except where the curvature, the change of orientation or the external axes need a lower speed.
		/// The points must describe a smooth path: close or noisy points give high curvatures and a slow motion.
		/// </summary>
		/// <param name="points">Positions to pass through. A first position equal to the current position is ignored.
		///             Two consecutive positions cannot have the same X, Y, Z with different orientations.</param>
		/// <param name="speed">Speed in mm/s</param>
		/// <param name="termination">Termination at the last position: stop, overlap or corner</param>
		/// <param name="accelerationPercent">Acceleration and jerk in percent of the limits (greater than 0, up to 100)</param>
		public CartesianPathBuilder MoveSpline(CartesianPose[] points, double speed, Termination termination, double accelerationPercent = 100)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds a full circle in the XY plane of a frame, counterclockwise around its Z axis.
		/// The circle starts and ends at the point (radius, 0, 0) of the frame. A linear motion to this point is added first when the tool is not there.
		/// The orientation of the tool does not change.
		/// </summary>
		/// <param name="plane">Frame of the circle, in the user frame of the planner: its origin is the center and its XY plane is the plane of the circle</param>
		/// <param name="radius">Radius in mm</param>
		/// <param name="speed">Speed in mm/s. It is reduced if the curvature needs it.</param>
		/// <param name="termination">Termination at the end of the circle: stop, overlap or corner</param>
		/// <param name="accelerationPercent">Acceleration and jerk in percent of the limits (greater than 0, up to 100)</param>
		public CartesianPathBuilder AddCircle(CartesianPose plane, double radius, double speed, Termination termination, double accelerationPercent = 100)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds a helix around the Z axis of a frame, counterclockwise. It starts at the point (radius, 0, 0) of the frame
		/// and rises by the pitch along Z at each turn. A linear motion to the start point is added first when the tool is not there.
		/// The orientation of the tool does not change.
		/// </summary>
		/// <param name="plane">Frame of the helix, in the user frame of the planner: its origin is the center of the first turn</param>
		/// <param name="radius">Radius in mm</param>
		/// <param name="pitch">Distance along Z of the frame for each turn, in mm (negative to go down)</param>
		/// <param name="turns">Number of turns (greater than 0, can be fractional)</param>
		/// <param name="speed">Speed in mm/s. It is reduced if the curvature needs it.</param>
		/// <param name="termination">Termination at the end of the helix: stop, overlap or corner</param>
		/// <param name="accelerationPercent">Acceleration and jerk in percent of the limits (greater than 0, up to 100)</param>
		public CartesianPathBuilder AddHelix(CartesianPose plane, double radius, double pitch, double turns, double speed, Termination termination, double accelerationPercent = 100)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds a spiral in the XY plane of a frame, counterclockwise around its Z axis. The distance to the center changes regularly
		/// from the start radius to the end radius (Archimedean spiral). It starts at the point (startRadius, 0, 0) of the frame.
		/// A linear motion to the start point is added first when the tool is not there. The orientation of the tool does not change.
		/// </summary>
		/// <param name="plane">Frame of the spiral, in the user frame of the planner: its origin is the center and its XY plane is the plane of the spiral</param>
		/// <param name="startRadius">Distance to the center at the start, in mm (0 or more)</param>
		/// <param name="endRadius">Distance to the center at the end, in mm (0 or more)</param>
		/// <param name="turns">Number of turns (greater than 0, can be fractional)</param>
		/// <param name="speed">Speed in mm/s. It is reduced if the curvature needs it.</param>
		/// <param name="termination">Termination at the end of the spiral: stop, overlap or corner</param>
		/// <param name="accelerationPercent">Acceleration and jerk in percent of the limits (greater than 0, up to 100)</param>
		public CartesianPathBuilder AddSpiral(CartesianPose plane, double startRadius, double endRadius, double turns, double speed, Termination termination, double accelerationPercent = 100)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds a rectangle centered on the origin of a frame, in its XY plane: the width is along X and the height along Y.
		/// It starts and ends at the middle of the side at +X, the point (width / 2, 0, 0) of the frame, and turns counterclockwise around Z.
		/// With a corner radius, the corners are circle arcs of this radius, and the curvature changes progressively at their ends.
		/// Without corner radius, the robot stops at each corner.
		/// A linear motion to the start point is added first when the tool is not there. The orientation of the tool does not change.
		/// </summary>
		/// <param name="plane">Frame of the rectangle, in the user frame of the planner</param>
		/// <param name="width">Size along X of the frame in mm</param>
		/// <param name="height">Size along Y of the frame in mm</param>
		/// <param name="cornerRadius">Radius of the corners in mm, from 0 to half of the smallest side</param>
		/// <param name="speed">Speed in mm/s. It is reduced if the curvature needs it.</param>
		/// <param name="termination">Termination at the end of the rectangle: stop, overlap or corner</param>
		/// <param name="accelerationPercent">Acceleration and jerk in percent of the limits (greater than 0, up to 100)</param>
		public CartesianPathBuilder AddRectangle(CartesianPose plane, double width, double height, double cornerRadius, double speed, Termination termination, double accelerationPercent = 100)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Adds a regular polygon centered on the origin of a frame, in its XY plane. One side is perpendicular to X:
		/// the polygon starts and ends at the middle of this side, and turns counterclockwise around Z.
		/// With a corner radius, the corners are circle arcs of this radius, and the curvature changes progressively at their ends.
		/// Without corner radius, the robot stops at each corner.
		/// A linear motion to the start point is added first when the tool is not there. The orientation of the tool does not change.
		/// </summary>
		/// <param name="plane">Frame of the polygon, in the user frame of the planner</param>
		/// <param name="sideCount">Number of sides (3 or more)</param>
		/// <param name="radius">Distance from the center to the corners (circumscribed circle), in mm</param>
		/// <param name="cornerRadius">Radius of the corners in mm (0 for sharp corners)</param>
		/// <param name="speed">Speed in mm/s. It is reduced if the curvature needs it.</param>
		/// <param name="termination">Termination at the end of the polygon: stop, overlap or corner</param>
		/// <param name="accelerationPercent">Acceleration and jerk in percent of the limits (greater than 0, up to 100)</param>
		public CartesianPathBuilder AddPolygon(CartesianPose plane, int sideCount, double radius, double cornerRadius, double speed, Termination termination, double accelerationPercent = 100)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Keeps the current position during a given time
		/// </summary>
		/// <param name="duration">Duration in seconds</param>
		public CartesianPathBuilder Wait(double duration)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Writes a digital signal when the previous motion ends
		/// </summary>
		/// <param name="signal">Signal to write</param>
		/// <param name="value">Value to write</param>
		public CartesianPathBuilder SetIO(DigitalSignal signal, bool value)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates the trajectory. Its poses are flange poses in the world frame when the tool and user frames of the planner are set.
		/// </summary>
		public Trajectory Build()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Pose at the end of the motions added so far, as a pose of the tool in the user frame of the planner
		/// </summary>
		public CartesianPose EndPosition { get; }
	}
}
